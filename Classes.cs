using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace TP3
{
    class Classes
    {
        Classes() { }
    }

    class ConnectionManager
    {
        public OracleConnection OraCon = new();

        public string AdvancedSettings = "";
        public string Username = "";
        public string Password = "";

        public string ConnChain
        {
            get
            {
                return $"Data Source ={AdvancedSettings} ;" + $"user id ={Username}; " + $"Password={Password}";
            }
            private set { }
        } //advSettings + username + password

        public bool HasActiveConnection
        {
            get
            {
                if (OraCon.State == System.Data.ConnectionState.Open || OraCon.State == System.Data.ConnectionState.Executing || OraCon.State == System.Data.ConnectionState.Fetching)
                    return true;
                else
                    return false;
            }
            private set { }
        } // return true if active

        public bool TestConnection()
        {
            if (!HasActiveConnection) // return result of connection after colsing (just testing here)
            {
                bool Res = Connect();
                OraCon.Close();
                return Res;
            }
            else //close conn then test
            {
                OraCon.Close();
                bool Res = Connect();
                OraCon.Close();
                return Res;
            }
        }

        public bool Connect()
        {
            OraCon.ConnectionString = ConnChain;

            try
            {
                OraCon.Open();
            }
            catch { return false; }

            return HasActiveConnection;
        }

        public bool InsertIntoConn(string InsertCMD)
        {
            try
            {
                using (OracleCommand CMD = new(InsertCMD, OraCon))
                {
                    CMD.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }

        }
    }

    class SearchRes
    {
        public List<SearchData> SearchDatas { get; set; } = [];
        public float AVGPrice
        {
            get
            {
                float AVG = 0;
                foreach (SearchData data in SearchDatas)
                    AVG += data.PrixBase;
                AVG /= SearchDatas.Count;
                return AVG;
            }
            private set { }
        }

        public SearchType ST;

        public (float min, float max) Prices { get; set; } = (0, 0);
        public (int min, int max) Quality { get; set; } = (0, 0);

        public void FillPQ(string minP, string maxP, string minQ, string maxQ)
        {
            if (string.IsNullOrEmpty(minP))
                minP = "0";
            if (string.IsNullOrEmpty(maxP))
                maxP = "1000";
            if (string.IsNullOrEmpty(minQ))
                minQ = "0";
            if (string.IsNullOrEmpty(maxQ))
                maxQ = "100";

            float MP = float.Parse(minP);
            float MAP = float.Parse(maxP);
            int Mq = int.Parse(minQ);
            int MAq = int.Parse(maxQ);

            Prices = (MP, MAP);
            Quality = (Mq, MAq);
        }

        public List<SearchData> GetFilteredData(string SearchTerm)
        {
            List<SearchData> NSD = GetPQPreSearch();

            if (ST == SearchType.Nom)
                NSD = SearchByName(NSD, SearchTerm);
            else if (ST == SearchType.Classe)
                NSD = SearchByClass(NSD, SearchTerm);
            else if (ST == SearchType.Quality)
                NSD = SearchByQuality(NSD, SearchTerm);
            else
                throw new Exception("No class Selected");

            return NSD;
        }

        static List<SearchData> SearchByName(List<SearchData> LSD, string Name)
        {
            return LSD.Where(item => item.NomEquip.Contains(Name)).ToList();
        }

        static List<SearchData> SearchByClass(List<SearchData> LSD, string ClassName)
        {
            return LSD.Where(item => item.NomClasse.Contains(ClassName)).ToList();
        }

        static List<SearchData> SearchByQuality(List<SearchData> LSD, string Quality)
        {
            return LSD.Where(item => item.Quality.ToString().Contains(Quality)).ToList();
        }

        List<SearchData> GetPQPreSearch()
        {
            List<SearchData> NSD = [];

            foreach (SearchData data in SearchDatas)
                if (data.PrixBase > Prices.min && data.PrixBase < Prices.max)
                    if (data.Quality > Quality.min && data.Quality < Quality.max)
                        NSD.Add(data);

            return NSD;
        }

        public void AddNewLine(string nom, string NClasse, int quality, float prixBase, string Specialisation)
        {
            SearchDatas.Add(new(nom, NClasse, quality, prixBase, Specialisation));
        }

        public bool AddNewLines(OracleDataReader R)
        {
            try
            {
                while (R.Read())
                {
                    string S2 = R.GetString(0);
                    string S1 = R.GetString(1);
                    int S3 = R.GetInt32(2);
                    float S4 = R.GetFloat(3);
                    string S5;
                    try
                    {
                        S5 = R.GetString(4);
                    }
                    catch
                    {
                        S5 = "Empty";
                    }

                    AddNewLine(S1, S2, S3, S4, S5);
                }
            }
            catch { return false; }
            return true;
        }

        public bool AddAllLinesFromCommand(string CMD, ConnectionManager CM)
        {
            using (OracleCommand ReadCMD = new(CMD, CM.OraCon))
            {
                try
                {
                    ReadCMD.ExecuteScalar().ToString();
                }
                catch { return false; }

                using (OracleDataReader reader = ReadCMD.ExecuteReader())
                {
                    return AddNewLines(reader);
                }
            }
        }

        public void ReorderBy(int index, bool asc)
        {
            switch (index)
            {
                case 0: // Order by NomEquip
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.NomEquip).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.NomEquip).ToList();
                    break;
                case 1: // Order by NomClasse
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.NomClasse).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.NomClasse).ToList();
                    break;
                case 2: // Order by Quality
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.Quality).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.Quality).ToList();
                    break;
                case 3: // Order by PrixBase
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.PrixBase).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.PrixBase).ToList();
                    break;
                case 4: // Order by Specialisation
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.Specialisation).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.Specialisation).ToList();
                    break;
                default: // Handle invalid index
                    if (asc)
                        SearchDatas = SearchDatas.OrderBy(data => data.NomEquip).ToList();
                    else
                        SearchDatas = SearchDatas.OrderByDescending(data => data.NomEquip).ToList();
                    break;
            }
        }
    }

    struct SearchData(string nomEquip, string nomClasse, int quality, float prixBase, string specialisation)
    {
        public string NomEquip { get; set; } = nomEquip;
        public string NomClasse { get; set; } = nomClasse;
        public int Quality { get; set; } = quality;
        public float PrixBase { get; set; } = prixBase;
        public string Specialisation { get; set; } = specialisation;
    }

    public enum SearchType
    {
        Nom,
        Classe,
        Quality
    }
}
