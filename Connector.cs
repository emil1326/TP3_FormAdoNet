using Oracle.ManagedDataAccess.Client;

namespace TP3
{
    class Connector
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

        public Connector()
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
            catch (Exception ex) { return false; }

            return HasActiveConnection;
        }
    }
}
