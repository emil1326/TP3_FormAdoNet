namespace TP3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MyMainMenuStrip = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            ouvrirUneConnectionToolStripMenuItem = new ToolStripMenuItem();
            fermerLaConnectionToolStripMenuItem = new ToolStripMenuItem();
            forcerLeRafraichisementToolStripMenuItem = new ToolStripMenuItem();
            rechercheToolStripMenuItem = new ToolStripMenuItem();
            parNomToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            qualiterToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            nouvelleClasseToolStripMenuItem = new ToolStripMenuItem();
            nouvelleItemToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            existingItemToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipaleToolStripMenuItem = new ToolStripMenuItem();
            OpenConnPannel = new GroupBox();
            ConnectionResult = new Label();
            SaveConn = new Button();
            TextConnectionButton = new Button();
            AdvancedOptions = new GroupBox();
            AdvancedOptionTextBox = new TextBox();
            groupBox1 = new GroupBox();
            PasswordTextBox = new TextBox();
            AdvancedLoginOptionsCheckBox = new CheckBox();
            UserNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ResearchPannel = new GroupBox();
            dataGridView2 = new DataGridView();
            SearchErrTxt = new Label();
            SearchButton = new Button();
            FilterByGB = new GroupBox();
            label6 = new Label();
            QualiterTBmax = new TextBox();
            QualityTBMin = new TextBox();
            PrixTBMax = new TextBox();
            PrixTBMin = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SearchByTypeCB = new ComboBox();
            SearchBar = new TextBox();
            ModExistingItemWind = new GroupBox();
            AddEquipWind = new GroupBox();
            SpecSelPass = new Label();
            ClasSelPassed = new Label();
            AddEquipSpecCB = new ComboBox();
            label11 = new Label();
            AddEquiLabel = new Label();
            ButEqui = new Button();
            AddEquipClassCB = new ComboBox();
            label15 = new Label();
            TBprice = new TextBox();
            label14 = new Label();
            TBqualite = new TextBox();
            label13 = new Label();
            TBnameEqui = new TextBox();
            label12 = new Label();
            AddClassWind = new GroupBox();
            AddClassWindowLabel = new Label();
            ButtonAddNewClass = new Button();
            TBspecClass = new TextBox();
            label10 = new Label();
            TBnameClass = new TextBox();
            label9 = new Label();
            label8 = new Label();
            TBidClass = new TextBox();
            label7 = new Label();
            HelloWind = new GroupBox();
            label3 = new Label();
            MyMainMenuStrip.SuspendLayout();
            OpenConnPannel.SuspendLayout();
            AdvancedOptions.SuspendLayout();
            groupBox1.SuspendLayout();
            ResearchPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            FilterByGB.SuspendLayout();
            AddEquipWind.SuspendLayout();
            AddClassWind.SuspendLayout();
            HelloWind.SuspendLayout();
            SuspendLayout();
            // 
            // MyMainMenuStrip
            // 
            MyMainMenuStrip.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, rechercheToolStripMenuItem, ajouterToolStripMenuItem, modifyToolStripMenuItem, menuPrincipaleToolStripMenuItem });
            MyMainMenuStrip.Location = new Point(0, 0);
            MyMainMenuStrip.Name = "MyMainMenuStrip";
            MyMainMenuStrip.Size = new Size(800, 24);
            MyMainMenuStrip.TabIndex = 0;
            MyMainMenuStrip.Text = "MainMenuStrip";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirUneConnectionToolStripMenuItem, fermerLaConnectionToolStripMenuItem, forcerLeRafraichisementToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
            // 
            // ouvrirUneConnectionToolStripMenuItem
            // 
            ouvrirUneConnectionToolStripMenuItem.Name = "ouvrirUneConnectionToolStripMenuItem";
            ouvrirUneConnectionToolStripMenuItem.Size = new Size(204, 22);
            ouvrirUneConnectionToolStripMenuItem.Text = "Ouvrir une connection";
            ouvrirUneConnectionToolStripMenuItem.Click += OuvrirUneConnectionToolStripMenuItem_Click;
            // 
            // fermerLaConnectionToolStripMenuItem
            // 
            fermerLaConnectionToolStripMenuItem.Name = "fermerLaConnectionToolStripMenuItem";
            fermerLaConnectionToolStripMenuItem.Size = new Size(204, 22);
            fermerLaConnectionToolStripMenuItem.Text = "Fermer la connection";
            fermerLaConnectionToolStripMenuItem.Click += FermerLaConnectionToolStripMenuItem_Click;
            // 
            // forcerLeRafraichisementToolStripMenuItem
            // 
            forcerLeRafraichisementToolStripMenuItem.Name = "forcerLeRafraichisementToolStripMenuItem";
            forcerLeRafraichisementToolStripMenuItem.Size = new Size(204, 22);
            forcerLeRafraichisementToolStripMenuItem.Text = "Forcer le rafraichisement";
            forcerLeRafraichisementToolStripMenuItem.Click += ForcerLeRafraichisementToolStripMenuItem_Click;
            // 
            // rechercheToolStripMenuItem
            // 
            rechercheToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parNomToolStripMenuItem, cToolStripMenuItem, qualiterToolStripMenuItem });
            rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            rechercheToolStripMenuItem.Size = new Size(74, 20);
            rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // parNomToolStripMenuItem
            // 
            parNomToolStripMenuItem.Name = "parNomToolStripMenuItem";
            parNomToolStripMenuItem.Size = new Size(119, 22);
            parNomToolStripMenuItem.Text = "Par nom";
            parNomToolStripMenuItem.Click += ParNomToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(119, 22);
            cToolStripMenuItem.Text = "Classe";
            cToolStripMenuItem.Click += CToolStripMenuItem_Click;
            // 
            // qualiterToolStripMenuItem
            // 
            qualiterToolStripMenuItem.Name = "qualiterToolStripMenuItem";
            qualiterToolStripMenuItem.Size = new Size(119, 22);
            qualiterToolStripMenuItem.Text = "Qualiter";
            qualiterToolStripMenuItem.Click += QualiterToolStripMenuItem_Click;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nouvelleClasseToolStripMenuItem, nouvelleItemToolStripMenuItem });
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(58, 20);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // nouvelleClasseToolStripMenuItem
            // 
            nouvelleClasseToolStripMenuItem.Name = "nouvelleClasseToolStripMenuItem";
            nouvelleClasseToolStripMenuItem.Size = new Size(157, 22);
            nouvelleClasseToolStripMenuItem.Text = "Nouvelle Classe";
            nouvelleClasseToolStripMenuItem.Click += NouvelleClasseToolStripMenuItem_Click;
            // 
            // nouvelleItemToolStripMenuItem
            // 
            nouvelleItemToolStripMenuItem.Name = "nouvelleItemToolStripMenuItem";
            nouvelleItemToolStripMenuItem.Size = new Size(157, 22);
            nouvelleItemToolStripMenuItem.Text = "Nouvelle item";
            nouvelleItemToolStripMenuItem.Click += NouvelleItemToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { existingItemToolStripMenuItem });
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(57, 20);
            modifyToolStripMenuItem.Text = "Modify";
            // 
            // existingItemToolStripMenuItem
            // 
            existingItemToolStripMenuItem.Name = "existingItemToolStripMenuItem";
            existingItemToolStripMenuItem.Size = new Size(142, 22);
            existingItemToolStripMenuItem.Text = "Item existant";
            existingItemToolStripMenuItem.Click += ExistingItemToolStripMenuItem_Click;
            // 
            // menuPrincipaleToolStripMenuItem
            // 
            menuPrincipaleToolStripMenuItem.Name = "menuPrincipaleToolStripMenuItem";
            menuPrincipaleToolStripMenuItem.Size = new Size(99, 20);
            menuPrincipaleToolStripMenuItem.Text = "Menu principal";
            menuPrincipaleToolStripMenuItem.Click += MenuPrincipaleToolStripMenuItem_Click;
            // 
            // OpenConnPannel
            // 
            OpenConnPannel.Controls.Add(ConnectionResult);
            OpenConnPannel.Controls.Add(SaveConn);
            OpenConnPannel.Controls.Add(TextConnectionButton);
            OpenConnPannel.Controls.Add(AdvancedOptions);
            OpenConnPannel.Controls.Add(groupBox1);
            OpenConnPannel.Location = new Point(12, 27);
            OpenConnPannel.Name = "OpenConnPannel";
            OpenConnPannel.Size = new Size(776, 411);
            OpenConnPannel.TabIndex = 1;
            OpenConnPannel.TabStop = false;
            OpenConnPannel.Text = "Ouvrir une connection";
            // 
            // ConnectionResult
            // 
            ConnectionResult.AutoSize = true;
            ConnectionResult.Location = new Point(232, 165);
            ConnectionResult.Name = "ConnectionResult";
            ConnectionResult.Size = new Size(160, 15);
            ConnectionResult.TabIndex = 5;
            ConnectionResult.Text = "Aucun essaie de connections";
            // 
            // SaveConn
            // 
            SaveConn.Location = new Point(135, 161);
            SaveConn.Name = "SaveConn";
            SaveConn.Size = new Size(91, 23);
            SaveConn.TabIndex = 4;
            SaveConn.Text = "Connect";
            SaveConn.UseVisualStyleBackColor = true;
            SaveConn.Click += SaveConn_Click;
            // 
            // TextConnectionButton
            // 
            TextConnectionButton.Location = new Point(6, 161);
            TextConnectionButton.Name = "TextConnectionButton";
            TextConnectionButton.Size = new Size(123, 23);
            TextConnectionButton.TabIndex = 3;
            TextConnectionButton.Text = "Tester la connection";
            TextConnectionButton.UseVisualStyleBackColor = true;
            TextConnectionButton.Click += TextConnectionButton_Click;
            // 
            // AdvancedOptions
            // 
            AdvancedOptions.Controls.Add(AdvancedOptionTextBox);
            AdvancedOptions.Location = new Point(232, 22);
            AdvancedOptions.Name = "AdvancedOptions";
            AdvancedOptions.Size = new Size(334, 133);
            AdvancedOptions.TabIndex = 2;
            AdvancedOptions.TabStop = false;
            AdvancedOptions.Text = "Parametres avancer";
            AdvancedOptions.Visible = false;
            // 
            // AdvancedOptionTextBox
            // 
            AdvancedOptionTextBox.Location = new Point(6, 22);
            AdvancedOptionTextBox.Multiline = true;
            AdvancedOptionTextBox.Name = "AdvancedOptionTextBox";
            AdvancedOptionTextBox.Size = new Size(322, 105);
            AdvancedOptionTextBox.TabIndex = 0;
            AdvancedOptionTextBox.Text = "(DESCRIPTION = (ADDRESS_LIST = \r\n(ADDRESS = (PROTOCOL = TCP)\r\n(HOST = 205.237.244.252) (PORT = 1521)))\r\n(CONNECT_DATA =(SERVICE_NAME = orcl)))";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PasswordTextBox);
            groupBox1.Controls.Add(AdvancedLoginOptionsCheckBox);
            groupBox1.Controls.Add(UserNameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(6, 81);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(208, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AdvancedLoginOptionsCheckBox
            // 
            AdvancedLoginOptionsCheckBox.AutoSize = true;
            AdvancedLoginOptionsCheckBox.Location = new Point(6, 110);
            AdvancedLoginOptionsCheckBox.Name = "AdvancedLoginOptionsCheckBox";
            AdvancedLoginOptionsCheckBox.Size = new Size(69, 19);
            AdvancedLoginOptionsCheckBox.TabIndex = 1;
            AdvancedLoginOptionsCheckBox.Text = "Avancer";
            AdvancedLoginOptionsCheckBox.UseVisualStyleBackColor = true;
            AdvancedLoginOptionsCheckBox.CheckedChanged += AdvancedLoginOptionsCheckBox_CheckedChanged;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(6, 37);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(208, 23);
            UserNameTextBox.TabIndex = 2;
            UserNameTextBox.Text = "c##DevauchE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // ResearchPannel
            // 
            ResearchPannel.Controls.Add(dataGridView2);
            ResearchPannel.Controls.Add(SearchErrTxt);
            ResearchPannel.Controls.Add(SearchButton);
            ResearchPannel.Controls.Add(FilterByGB);
            ResearchPannel.Controls.Add(SearchBar);
            ResearchPannel.Location = new Point(12, 27);
            ResearchPannel.Name = "ResearchPannel";
            ResearchPannel.Size = new Size(776, 411);
            ResearchPannel.TabIndex = 0;
            ResearchPannel.TabStop = false;
            ResearchPannel.Text = "Recherche";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 52);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(554, 351);
            dataGridView2.TabIndex = 11;
            // 
            // SearchErrTxt
            // 
            SearchErrTxt.AutoSize = true;
            SearchErrTxt.Location = new Point(566, 52);
            SearchErrTxt.Name = "SearchErrTxt";
            SearchErrTxt.Size = new Size(51, 15);
            SearchErrTxt.TabIndex = 10;
            SearchErrTxt.Text = "No error";
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(498, 22);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(121, 24);
            SearchButton.TabIndex = 8;
            SearchButton.Text = "Rechercher";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // FilterByGB
            // 
            FilterByGB.Controls.Add(label6);
            FilterByGB.Controls.Add(QualiterTBmax);
            FilterByGB.Controls.Add(QualityTBMin);
            FilterByGB.Controls.Add(PrixTBMax);
            FilterByGB.Controls.Add(PrixTBMin);
            FilterByGB.Controls.Add(label5);
            FilterByGB.Controls.Add(label4);
            FilterByGB.Controls.Add(SearchByTypeCB);
            FilterByGB.Location = new Point(625, 19);
            FilterByGB.Name = "FilterByGB";
            FilterByGB.Size = new Size(134, 384);
            FilterByGB.TabIndex = 1;
            FilterByGB.TabStop = false;
            FilterByGB.Text = "Filtrer par";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 164);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 7;
            label6.Text = "Qualité";
            // 
            // QualiterTBmax
            // 
            QualiterTBmax.Location = new Point(72, 182);
            QualiterTBmax.Name = "QualiterTBmax";
            QualiterTBmax.PlaceholderText = "Max";
            QualiterTBmax.Size = new Size(58, 23);
            QualiterTBmax.TabIndex = 6;
            // 
            // QualityTBMin
            // 
            QualityTBMin.Location = new Point(8, 182);
            QualityTBMin.Name = "QualityTBMin";
            QualityTBMin.PlaceholderText = "Min";
            QualityTBMin.Size = new Size(58, 23);
            QualityTBMin.TabIndex = 5;
            // 
            // PrixTBMax
            // 
            PrixTBMax.Location = new Point(72, 113);
            PrixTBMax.Name = "PrixTBMax";
            PrixTBMax.PlaceholderText = "$ Max";
            PrixTBMax.Size = new Size(58, 23);
            PrixTBMax.TabIndex = 4;
            // 
            // PrixTBMin
            // 
            PrixTBMin.Location = new Point(7, 113);
            PrixTBMin.Name = "PrixTBMin";
            PrixTBMin.PlaceholderText = "$ Min";
            PrixTBMin.Size = new Size(58, 23);
            PrixTBMin.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 93);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 2;
            label5.Text = "Prix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "Recherche";
            // 
            // SearchByTypeCB
            // 
            SearchByTypeCB.FormattingEnabled = true;
            SearchByTypeCB.Items.AddRange(new object[] { "Nom", "Classe", "Qualité" });
            SearchByTypeCB.Location = new Point(6, 40);
            SearchByTypeCB.Name = "SearchByTypeCB";
            SearchByTypeCB.Size = new Size(121, 23);
            SearchByTypeCB.TabIndex = 0;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(6, 22);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(486, 23);
            SearchBar.TabIndex = 0;
            // 
            // ModExistingItemWind
            // 
            ModExistingItemWind.Location = new Point(12, 27);
            ModExistingItemWind.Name = "ModExistingItemWind";
            ModExistingItemWind.Size = new Size(776, 411);
            ModExistingItemWind.TabIndex = 0;
            ModExistingItemWind.TabStop = false;
            ModExistingItemWind.Text = "Modifier un item existant";
            // 
            // AddEquipWind
            // 
            AddEquipWind.Controls.Add(SpecSelPass);
            AddEquipWind.Controls.Add(ClasSelPassed);
            AddEquipWind.Controls.Add(AddEquipSpecCB);
            AddEquipWind.Controls.Add(label11);
            AddEquipWind.Controls.Add(AddEquiLabel);
            AddEquipWind.Controls.Add(ButEqui);
            AddEquipWind.Controls.Add(AddEquipClassCB);
            AddEquipWind.Controls.Add(label15);
            AddEquipWind.Controls.Add(TBprice);
            AddEquipWind.Controls.Add(label14);
            AddEquipWind.Controls.Add(TBqualite);
            AddEquipWind.Controls.Add(label13);
            AddEquipWind.Controls.Add(TBnameEqui);
            AddEquipWind.Controls.Add(label12);
            AddEquipWind.Location = new Point(12, 27);
            AddEquipWind.Name = "AddEquipWind";
            AddEquipWind.Size = new Size(776, 411);
            AddEquipWind.TabIndex = 0;
            AddEquipWind.TabStop = false;
            AddEquipWind.Text = "Ajouter un equipement";
            // 
            // SpecSelPass
            // 
            SpecSelPass.AutoSize = true;
            SpecSelPass.Location = new Point(220, 244);
            SpecSelPass.Name = "SpecSelPass";
            SpecSelPass.Size = new Size(0, 15);
            SpecSelPass.TabIndex = 15;
            // 
            // ClasSelPassed
            // 
            ClasSelPassed.AutoSize = true;
            ClasSelPassed.Location = new Point(220, 199);
            ClasSelPassed.Name = "ClasSelPassed";
            ClasSelPassed.Size = new Size(0, 15);
            ClasSelPassed.TabIndex = 14;
            // 
            // AddEquipSpecCB
            // 
            AddEquipSpecCB.FormattingEnabled = true;
            AddEquipSpecCB.Location = new Point(6, 241);
            AddEquipSpecCB.Name = "AddEquipSpecCB";
            AddEquipSpecCB.Size = new Size(208, 23);
            AddEquipSpecCB.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 223);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 12;
            label11.Text = "Specialisation";
            // 
            // AddEquiLabel
            // 
            AddEquiLabel.AutoSize = true;
            AddEquiLabel.Location = new Point(226, 49);
            AddEquiLabel.Name = "AddEquiLabel";
            AddEquiLabel.Size = new Size(0, 15);
            AddEquiLabel.TabIndex = 11;
            // 
            // ButEqui
            // 
            ButEqui.Location = new Point(6, 276);
            ButEqui.Name = "ButEqui";
            ButEqui.Size = new Size(208, 59);
            ButEqui.TabIndex = 10;
            ButEqui.Text = "Ajouter l'équipement";
            ButEqui.UseVisualStyleBackColor = true;
            ButEqui.Click += ButEqui_Click;
            // 
            // AddEquipClassCB
            // 
            AddEquipClassCB.FormattingEnabled = true;
            AddEquipClassCB.Location = new Point(6, 196);
            AddEquipClassCB.Name = "AddEquipClassCB";
            AddEquipClassCB.Size = new Size(208, 23);
            AddEquipClassCB.TabIndex = 9;
            AddEquipClassCB.SelectedIndexChanged += AddEquipClassCB_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 178);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 8;
            label15.Text = "Classe";
            // 
            // TBprice
            // 
            TBprice.Location = new Point(6, 146);
            TBprice.Name = "TBprice";
            TBprice.Size = new Size(208, 23);
            TBprice.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 129);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 6;
            label14.Text = "Prix de base";
            // 
            // TBqualite
            // 
            TBqualite.Location = new Point(6, 93);
            TBqualite.MaxLength = 2;
            TBqualite.Name = "TBqualite";
            TBqualite.Size = new Size(208, 23);
            TBqualite.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 75);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 4;
            label13.Text = "Qualité";
            // 
            // TBnameEqui
            // 
            TBnameEqui.Location = new Point(6, 44);
            TBnameEqui.MaxLength = 50;
            TBnameEqui.Name = "TBnameEqui";
            TBnameEqui.Size = new Size(208, 23);
            TBnameEqui.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 26);
            label12.Name = "label12";
            label12.Size = new Size(123, 15);
            label12.TabIndex = 2;
            label12.Text = "Nom de l'équipement";
            // 
            // AddClassWind
            // 
            AddClassWind.Controls.Add(AddClassWindowLabel);
            AddClassWind.Controls.Add(ButtonAddNewClass);
            AddClassWind.Controls.Add(TBspecClass);
            AddClassWind.Controls.Add(label10);
            AddClassWind.Controls.Add(TBnameClass);
            AddClassWind.Controls.Add(label9);
            AddClassWind.Controls.Add(label8);
            AddClassWind.Controls.Add(TBidClass);
            AddClassWind.Controls.Add(label7);
            AddClassWind.Location = new Point(12, 27);
            AddClassWind.Name = "AddClassWind";
            AddClassWind.Size = new Size(776, 411);
            AddClassWind.TabIndex = 0;
            AddClassWind.TabStop = false;
            AddClassWind.Text = "Ajouter une nouvelle classe";
            // 
            // AddClassWindowLabel
            // 
            AddClassWindowLabel.AutoSize = true;
            AddClassWindowLabel.Location = new Point(238, 52);
            AddClassWindowLabel.Name = "AddClassWindowLabel";
            AddClassWindowLabel.Size = new Size(0, 15);
            AddClassWindowLabel.TabIndex = 6;
            // 
            // ButtonAddNewClass
            // 
            ButtonAddNewClass.Location = new Point(12, 223);
            ButtonAddNewClass.Name = "ButtonAddNewClass";
            ButtonAddNewClass.Size = new Size(220, 85);
            ButtonAddNewClass.TabIndex = 7;
            ButtonAddNewClass.Text = "Inséré";
            ButtonAddNewClass.UseVisualStyleBackColor = true;
            ButtonAddNewClass.Click += ButtonAddNewClass_Click;
            // 
            // TBspecClass
            // 
            TBspecClass.Location = new Point(12, 175);
            TBspecClass.MaxLength = 50;
            TBspecClass.Name = "TBspecClass";
            TBspecClass.Size = new Size(220, 23);
            TBspecClass.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 154);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 5;
            label10.Text = "Spécialisation";
            // 
            // TBnameClass
            // 
            TBnameClass.Location = new Point(12, 109);
            TBnameClass.MaxLength = 50;
            TBnameClass.Name = "TBnameClass";
            TBnameClass.Size = new Size(220, 23);
            TBnameClass.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 85);
            label9.Name = "label9";
            label9.Size = new Size(96, 15);
            label9.TabIndex = 3;
            label9.Text = "Nom de la classe";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 85);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 2;
            // 
            // TBidClass
            // 
            TBidClass.Location = new Point(12, 49);
            TBidClass.MaxLength = 3;
            TBidClass.Name = "TBidClass";
            TBidClass.Size = new Size(220, 23);
            TBidClass.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 31);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 0;
            label7.Text = "Id classe (3 caractères)";
            // 
            // HelloWind
            // 
            HelloWind.Controls.Add(label3);
            HelloWind.Location = new Point(12, 27);
            HelloWind.Name = "HelloWind";
            HelloWind.Size = new Size(776, 411);
            HelloWind.TabIndex = 5;
            HelloWind.TabStop = false;
            HelloWind.Text = "Bonjour!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(237, 30);
            label3.TabIndex = 0;
            label3.Text = "Bienvenue dans E&&M equipement manager\r\nvotre inventaire dequipements divers!\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MyMainMenuStrip);
            Controls.Add(AddEquipWind);
            Controls.Add(AddClassWind);
            Controls.Add(ResearchPannel);
            Controls.Add(OpenConnPannel);
            Controls.Add(HelloWind);
            Controls.Add(ModExistingItemWind);
            Name = "Form1";
            Text = "E&M Equipement Manager";
            MyMainMenuStrip.ResumeLayout(false);
            MyMainMenuStrip.PerformLayout();
            OpenConnPannel.ResumeLayout(false);
            OpenConnPannel.PerformLayout();
            AdvancedOptions.ResumeLayout(false);
            AdvancedOptions.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResearchPannel.ResumeLayout(false);
            ResearchPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            FilterByGB.ResumeLayout(false);
            FilterByGB.PerformLayout();
            AddEquipWind.ResumeLayout(false);
            AddEquipWind.PerformLayout();
            AddClassWind.ResumeLayout(false);
            AddClassWind.PerformLayout();
            HelloWind.ResumeLayout(false);
            HelloWind.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MyMainMenuStrip;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private ToolStripMenuItem fermerLaConnectionToolStripMenuItem;
        private ToolStripMenuItem forcerLeRafraichisementToolStripMenuItem;
        private ToolStripMenuItem rechercheToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem nouvelleClasseToolStripMenuItem;
        private ToolStripMenuItem nouvelleItemToolStripMenuItem;
        private ToolStripMenuItem ouvrirUneConnectionToolStripMenuItem;
        private ToolStripMenuItem parNomToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem qualiterToolStripMenuItem;
        private GroupBox OpenConnPannel;
        private GroupBox ResearchPannel;
        private GroupBox ModExistingItemWind;
        private GroupBox AddEquipWind;
        private GroupBox AddClassWind;
        private GroupBox groupBox1;
        private TextBox PasswordTextBox;
        private TextBox UserNameTextBox;
        private Label label2;
        private Label label1;
        private GroupBox AdvancedOptions;
        private TextBox AdvancedOptionTextBox;
        private CheckBox AdvancedLoginOptionsCheckBox;
        private Button TextConnectionButton;
        private Button SaveConn;
        private ToolStripMenuItem menuPrincipaleToolStripMenuItem;
        private GroupBox HelloWind;
        private Label label3;
        private Label ConnectionResult;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem existingItemToolStripMenuItem;
        private GroupBox FilterByGB;
        private TextBox SearchBar;
        private ComboBox SearchByTypeCB;
        private Label label4;
        private TextBox PrixTBMax;
        private TextBox PrixTBMin;
        private Label label5;
        private TextBox QualiterTBmax;
        private TextBox QualityTBMin;
        private Label label6;
        private Button SearchButton;
        private Label SearchErrTxt;
        private DataGridView dataGridView2;
        private TextBox TBidClass;
        private Label label7;
        private Label label8;
        private Button ButtonAddNewClass;
        private TextBox TBspecClass;
        private Label label10;
        private TextBox TBnameClass;
        private Label label9;
        private Label label12;
        private Label label13;
        private TextBox TBnameEqui;
        private Label label14;
        private TextBox TBqualite;
        private Label label15;
        private TextBox TBprice;
        private Button ButEqui;
        private ComboBox AddEquipClassCB;
        private Label AddClassWindowLabel;
        private Label AddEquiLabel;
        private ComboBox AddEquipSpecCB;
        private Label label11;
        private Label SpecSelPass;
        private Label ClasSelPassed;
    }
}
