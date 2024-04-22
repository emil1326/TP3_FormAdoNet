namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region PageManager

        private void ouvrirUneConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(1);
        }

        private void parNomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(2);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(3);
        }

        private void qualiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(4);
        }

        private void nouvelleClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(5);
        }

        private void nouvelleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(6);
        }

        private void menuPrincipaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(7);
        }

        private void existingItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(8);
        }

        void SwitchToPage(int Page)
        {
            Page--;

            GroupBox[] Pages =
            [
                OpenConnPannel,
                ResearchPannel,
                ResearchPannel,
                ResearchPannel,
                AddClassWind,
                AddEquipWind,
                HelloWind,
                ModExistingItemWind,
            ];
            foreach (GroupBox GB in Pages)
                GB.Visible = false;

            Pages[Page].Visible = true;
        }

        #endregion PageManager

        #region Login

        readonly ConnectionManager Conn = new();

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

        readonly SearchRes SR = new();

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string CMD = "    SELECT NOMCLASSE, NOMEQUIPEMENT, QUALITE, PRIXDEBASE, SPECIALISATION FROM EQUIPEMENTS JOIN CLASSES ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE WHERE QUALITE=20 ORDER BY QUALITE DESC";
            if (SR.AddAllLinesFromCommand(CMD, Conn))
                SearchErrTxt.Text = "no Error";
            else
            {
                SearchErrTxt.Text = "Error";
                return;
            }

            dataGridView2.DataSource = SR.searchDatas;
        }
    }
}
