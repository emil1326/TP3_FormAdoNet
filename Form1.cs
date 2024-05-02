namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region PageManager

        private void ForcerLeRafraichisementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDataFromDB();
        }

        private void FermerLaConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conn.OraCon.Close();
        }

        private void OuvrirUneConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(1);
        }

        private void ParNomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(2);
            InitSearchPage(0);
        }

        private void CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(3);
            InitSearchPage(1);
        }

        private void QualiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(4);
            InitSearchPage(2);
        }

        private void NouvelleClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(5);
        }

        private void NouvelleItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitCBAddEqui();
            SwitchToPage(6);
        }

        private void MenuPrincipaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToPage(7);
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

        #region Search

        readonly SearchRes SR = new();

        void InitSearchPage(int Page)
        {
            SearchByTypeCB.SelectedIndex = Page;

            GetDataFromDB();
        }

        void GetDataFromDB()
        {
            SR.SearchDatas.Clear();

            string CMD = "SELECT NOMCLASSE, NOMEQUIPEMENT, QUALITE, PRIXDEBASE, SPECIALISATION FROM EQUIPEMENTS JOIN CLASSES ON EQUIPEMENTS.IDCLASSE=CLASSES.IDCLASSE";

            if (SR.AddAllLinesFromCommand(CMD, Conn)) //pull from database at beginig only
                SearchErrTxt.Text = "no Error";
            else
            {
                SearchErrTxt.Text = "Error";
                return;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FillReq();
            SR.ST = GetSTFromCB();
            dataGridView2.DataSource = SR.GetFilteredData(SearchBar.Text);
        }

        SearchType GetSTFromCB()
        {
            if (SearchByTypeCB.SelectedIndex == 0)
                return SearchType.Nom;
            else if (SearchByTypeCB.SelectedIndex == 1)
                return SearchType.Classe;
            else if (SearchByTypeCB.SelectedIndex == 2)
                return SearchType.Quality;

            throw new Exception(" no sr");
        }

        void FillReq()
        {
            SR.FillPQ(PrixTBMin.Text, PrixTBMax.Text, QualityTBMin.Text, QualiterTBmax.Text);
        }

        #endregion Search

        #region Page ajouter

        private void ButtonAddNewClass_Click(object sender, EventArgs e)
        {
            string insertClassID = TBidClass.Text.Trim();
            string insertName = TBnameClass.Text.Trim();
            string insertSpec = TBspecClass.Text.Trim();

            string insertCMD = $"INSERT INTO CLASSES (IDCLASSE, NOMCLASSE, SPECIALISATION) VALUES ('{insertClassID}', '{insertName}', '{insertSpec}') ";

            if (Conn.InsertIntoConn(insertCMD))
                AddClassWindowLabel.Text = "Inséré!";
            else
                AddClassWindowLabel.Text = "Erreur";

        }

        #endregion

        void InitCBAddEqui()
        {
            (List<string> classes, bool Passed) = Conn.GetAllClasses();

            if (Passed)
                ClasSelPassed.Text = "Passed";
            else
            {
                ClasSelPassed.Text = "Err";
                return;
            }

            AddEquipClassCB.Items.Clear();

            for (int i = 0; i < classes.Count; i++)
                AddEquipClassCB.Items.Add(classes[i]);
        }

        void InitCBAddSpec()
        {
            (List<string> Specialisations, bool Passed) = Conn.GetAllSpecialisations(AddEquipClassCB.SelectedItem.ToString());

            if (Passed)
                SpecSelPass.Text = "Passed";
            else
            {
                SpecSelPass.Text = "Err";
                return;
            }

            AddEquipSpecCB.Items.Clear();

            for (int i = 0; i < Specialisations.Count; i++)
                AddEquipSpecCB.Items.Add(Specialisations[i]);
        }

        private void ButEqui_Click(object sender, EventArgs e)
        {
            string insertEquiName = TBnameEqui.Text.Trim();
            string insertQual = TBqualite.Text.Trim();
            string insertPrice = TBprice.Text.Trim();

            string insertClassName;
            string insertSpecName;

            try
            {
                insertClassName = AddEquipClassCB.SelectedItem.ToString().Trim();
                insertSpecName = AddEquipSpecCB.SelectedItem.ToString().Trim();
            }
            catch
            {
                CBErrLabel.Text = "ComboBox a pas une selection active (reselectioner svp)";
                return;
            }

            string insertCMD;

            if (string.IsNullOrEmpty(insertSpecName))
                insertCMD = $"INSERT INTO EQUIPEMENTS (IDEQUIPEMENT, NOMEQUIPEMENT, QUALITE, PRIXDEBASE, IDCLASSE) VALUES ((SELECT MAX(IDEQUIPEMENT) + 1 FROM EQUIPEMENTS), '{insertEquiName}' , {insertQual} , {insertPrice}, (SELECT IDCLASSE FROM CLASSES WHERE NOMCLASSE = '{insertClassName}'))";
            else
                insertCMD = $"INSERT INTO EQUIPEMENTS (IDEQUIPEMENT, NOMEQUIPEMENT, QUALITE, PRIXDEBASE, IDCLASSE) VALUES ((SELECT MAX(IDEQUIPEMENT) + 1 FROM EQUIPEMENTS), '{insertEquiName}' , {insertQual} , {insertPrice}, (SELECT IDCLASSE FROM CLASSES WHERE NOMCLASSE = '{insertClassName}'  AND SPECIALISATION = '{insertSpecName}'))";


            if (Conn.InsertIntoConn(insertCMD))
                AddEquiLabel.Text = "Inséré!";
            else
                AddEquiLabel.Text = "Erreur";

        }

        private void AddEquipClassCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitCBAddSpec();
        }
    }
}
