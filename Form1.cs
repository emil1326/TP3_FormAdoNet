namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Login

        Connector Conn = new();

        private void AdvancedLoginOptionsCheckBox_CheckedChanged(object sender, EventArgs e) //toggle advanced connection options 
        {
            if (AdvancedLoginOptionsCheckBox.Checked)
                AdvancedOptions.Visible = true;
            else
                AdvancedOptions.Visible = false;
        }

        private void TextConnectionButton_Click(object sender, EventArgs e) //connects temporarly 
        {
            if (ConnectToServer(true))
                ConnectionResult.Text = "test OK";
            else
                ConnectionResult.Text = "test Failed";
        } 

        private void SaveConn_Click(object sender, EventArgs e) //connects to server durably 
        {
            if (ConnectToServer())
                ConnectionResult.Text = "connection OK";
            else
                ConnectionResult.Text = "connection Failed";
        }

        bool ConnectToServer(bool Test = false) //handles connections 
        {
            FillConn();

            if (Test)
                return Conn.TestConnection();
            else
                return Conn.Connect();
        }

        void FillConn() //fill informations for connection 
        {
            Conn.AdvancedSettings = AdvancedOptionTextBox.Text;
            Conn.Password = PasswordTextBox.Text;
            Conn.Username = UserNameTextBox.Text;
        } 

        #endregion Login
    }
}
