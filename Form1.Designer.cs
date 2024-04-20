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
            ModExistingItemWind = new GroupBox();
            AddEquipWind = new GroupBox();
            AddClassWind = new GroupBox();
            HelloWind = new GroupBox();
            label3 = new Label();
            MyMainMenuStrip.SuspendLayout();
            OpenConnPannel.SuspendLayout();
            AdvancedOptions.SuspendLayout();
            groupBox1.SuspendLayout();
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
            ouvrirUneConnectionToolStripMenuItem.Click += ouvrirUneConnectionToolStripMenuItem_Click;
            // 
            // fermerLaConnectionToolStripMenuItem
            // 
            fermerLaConnectionToolStripMenuItem.Name = "fermerLaConnectionToolStripMenuItem";
            fermerLaConnectionToolStripMenuItem.Size = new Size(204, 22);
            fermerLaConnectionToolStripMenuItem.Text = "Fermer la connection";
            // 
            // forcerLeRafraichisementToolStripMenuItem
            // 
            forcerLeRafraichisementToolStripMenuItem.Name = "forcerLeRafraichisementToolStripMenuItem";
            forcerLeRafraichisementToolStripMenuItem.Size = new Size(204, 22);
            forcerLeRafraichisementToolStripMenuItem.Text = "Forcer le rafraichisement";
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
            parNomToolStripMenuItem.Click += parNomToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(119, 22);
            cToolStripMenuItem.Text = "Classe";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // qualiterToolStripMenuItem
            // 
            qualiterToolStripMenuItem.Name = "qualiterToolStripMenuItem";
            qualiterToolStripMenuItem.Size = new Size(119, 22);
            qualiterToolStripMenuItem.Text = "Qualiter";
            qualiterToolStripMenuItem.Click += qualiterToolStripMenuItem_Click;
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
            nouvelleClasseToolStripMenuItem.Click += nouvelleClasseToolStripMenuItem_Click;
            // 
            // nouvelleItemToolStripMenuItem
            // 
            nouvelleItemToolStripMenuItem.Name = "nouvelleItemToolStripMenuItem";
            nouvelleItemToolStripMenuItem.Size = new Size(157, 22);
            nouvelleItemToolStripMenuItem.Text = "Nouvelle item";
            nouvelleItemToolStripMenuItem.Click += nouvelleItemToolStripMenuItem_Click;
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
            existingItemToolStripMenuItem.Size = new Size(180, 22);
            existingItemToolStripMenuItem.Text = "Item existant";
            existingItemToolStripMenuItem.Click += existingItemToolStripMenuItem_Click;
            // 
            // menuPrincipaleToolStripMenuItem
            // 
            menuPrincipaleToolStripMenuItem.Name = "menuPrincipaleToolStripMenuItem";
            menuPrincipaleToolStripMenuItem.Size = new Size(105, 20);
            menuPrincipaleToolStripMenuItem.Text = "Menu principale";
            menuPrincipaleToolStripMenuItem.Click += menuPrincipaleToolStripMenuItem_Click;
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
            ResearchPannel.Location = new Point(12, 27);
            ResearchPannel.Name = "ResearchPannel";
            ResearchPannel.Size = new Size(776, 411);
            ResearchPannel.TabIndex = 0;
            ResearchPannel.TabStop = false;
            ResearchPannel.Text = "Recherche";
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
            AddEquipWind.Location = new Point(12, 27);
            AddEquipWind.Name = "AddEquipWind";
            AddEquipWind.Size = new Size(776, 411);
            AddEquipWind.TabIndex = 0;
            AddEquipWind.TabStop = false;
            AddEquipWind.Text = "Ajouter un equipement";
            // 
            // AddClassWind
            // 
            AddClassWind.Location = new Point(12, 27);
            AddClassWind.Name = "AddClassWind";
            AddClassWind.Size = new Size(776, 411);
            AddClassWind.TabIndex = 0;
            AddClassWind.TabStop = false;
            AddClassWind.Text = "Ajouter une nouvelle classe";
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
            Controls.Add(OpenConnPannel);
            Controls.Add(HelloWind);
            Controls.Add(AddClassWind);
            Controls.Add(AddEquipWind);
            Controls.Add(ModExistingItemWind);
            Controls.Add(ResearchPannel);
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
    }
}
