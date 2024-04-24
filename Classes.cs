using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP3
{
    class Classes
    {
        Classes() { }
    }

    class ConnectionManager
    {

        public void InsertIntoConn(string InsertCMD)
        {
            try
            {
                OracleCommand CMD = new OracleCommand(InsertCMD, OraCon);
             
                MessageBox.Show("Inséré!");
            }
            catch
            {
                MessageBox.Show("Erreur lors de l'insertion!");
            }
           
        }

        public OracleConnection OraCon = new();

        public string AdvancedSettings;
        public string Username;
        public string Password;

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

        public ConnectionManager()
        {
        }


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
    }

    class SearchRes
    {
        public List<SearchData> searchDatas { get; set; } = new();
        public float AVGPrice
        {
            get
            {
                float AVG = 0;
                foreach (SearchData data in searchDatas)
                    AVG += data.PrixBase;
                AVG /= searchDatas.Count;
                return AVG;
            }
            private set { }
        }

        public SearchType ST;

        public (float min, float max) prices { get; set; } = (0, 0);
        public (int min, int max) quality { get; set; } = (0, 0);

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

            prices = (MP, MAP);
            quality = (Mq, MAq);
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

        List<SearchData> SearchByName(List<SearchData> LSD, string Name)
        {
            return LSD.Where(item => item.NomEquip.Contains(Name)).ToList();
        }

        List<SearchData> SearchByClass(List<SearchData> LSD, string ClassName)
        {


            return LSD.Where(item => item.NomClasse.Contains(ClassName)).ToList();
        }

        List<SearchData> SearchByQuality(List<SearchData> LSD, string Quality)
        {
            return LSD.Where(item => item.Quality.ToString().Contains(Quality)).ToList();
        }


        List<SearchData> GetPQPreSearch()
        {
            List<SearchData> NSD = new();

            foreach (SearchData data in searchDatas)
                if (data.PrixBase > prices.min && data.PrixBase < prices.max)
                    if (data.Quality > quality.min && data.Quality < quality.max)
                        NSD.Add(data);

            return NSD;
        }

        public void AddNewLine(string nom, string NClasse, int quality, float prixBase, string Specialisation)
        {
            searchDatas.Add(new(nom, NClasse, quality, prixBase, Specialisation));
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
                        searchDatas = searchDatas.OrderBy(data => data.NomEquip).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.NomEquip).ToList();
                    break;
                case 1: // Order by NomClasse
                    if (asc)
                        searchDatas = searchDatas.OrderBy(data => data.NomClasse).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.NomClasse).ToList();
                    break;
                case 2: // Order by Quality
                    if (asc)
                        searchDatas = searchDatas.OrderBy(data => data.Quality).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.Quality).ToList();
                    break;
                case 3: // Order by PrixBase
                    if (asc)
                        searchDatas = searchDatas.OrderBy(data => data.PrixBase).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.PrixBase).ToList();
                    break;
                case 4: // Order by Specialisation
                    if (asc)
                        searchDatas = searchDatas.OrderBy(data => data.Specialisation).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.Specialisation).ToList();
                    break;
                default: // Handle invalid index
                    if (asc)
                        searchDatas = searchDatas.OrderBy(data => data.NomEquip).ToList();
                    else
                        searchDatas = searchDatas.OrderByDescending(data => data.NomEquip).ToList();
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
