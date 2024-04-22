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

        public DataSet DS;

        public void AddNewLine(string nom, string NClasse, int quality, float prixBase, string Specialisation)
        {
            searchDatas.Add(new(nom, NClasse, quality, prixBase, Specialisation));
        }

        public bool AddNewLines(OracleDataReader R)
        {
            try
            {
                while (R.Read())
                    AddNewLine(R.GetString(0), R.GetString(1), R.GetInt32(2), R.GetFloat(3), R.GetString(4));
            }
            catch { return false; }
            return true;
        }

        public bool AddNewLines(OracleDataReader R, int AMNT)
        {
            try
            {
                int Turns = 0;
                while (R.Read() && Turns < AMNT * 5) // *5 cuz 5 datas wanna have the lines inputed
                {
                    AddNewLine(R.GetString(0), R.GetString(1), R.GetInt32(2), R.GetFloat(3), R.GetString(4));
                    Turns++;
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
        public string NomEquip = nomEquip;
        public string NomClasse = nomClasse;
        public int Quality = quality;
        public float PrixBase = prixBase;
        public string Specialisation = specialisation;
    }

    class DS : DataSet
    {
        public DS()
        {

        }

    }
}
