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
            menuStrip1 = new MenuStrip();
            connectionToolStripMenuItem = new ToolStripMenuItem();
            fermerLaConnectionToolStripMenuItem = new ToolStripMenuItem();
            forcerLeRafraichisementToolStripMenuItem = new ToolStripMenuItem();
            rechercheToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            nouvelleClasseToolStripMenuItem = new ToolStripMenuItem();
            nouvelleItemToolStripMenuItem = new ToolStripMenuItem();
            ouvrirUneConnectionToolStripMenuItem = new ToolStripMenuItem();
            parNomToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            qualiterToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { connectionToolStripMenuItem, rechercheToolStripMenuItem, ajouterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            connectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirUneConnectionToolStripMenuItem, fermerLaConnectionToolStripMenuItem, forcerLeRafraichisementToolStripMenuItem });
            connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            connectionToolStripMenuItem.Size = new Size(81, 20);
            connectionToolStripMenuItem.Text = "Connection";
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
            // 
            // nouvelleItemToolStripMenuItem
            // 
            nouvelleItemToolStripMenuItem.Name = "nouvelleItemToolStripMenuItem";
            nouvelleItemToolStripMenuItem.Size = new Size(157, 22);
            nouvelleItemToolStripMenuItem.Text = "Nouvelle item";
            // 
            // ouvrirUneConnectionToolStripMenuItem
            // 
            ouvrirUneConnectionToolStripMenuItem.Name = "ouvrirUneConnectionToolStripMenuItem";
            ouvrirUneConnectionToolStripMenuItem.Size = new Size(204, 22);
            ouvrirUneConnectionToolStripMenuItem.Text = "Ouvrir une connection";
            // 
            // parNomToolStripMenuItem
            // 
            parNomToolStripMenuItem.Name = "parNomToolStripMenuItem";
            parNomToolStripMenuItem.Size = new Size(180, 22);
            parNomToolStripMenuItem.Text = "Par nom";
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(180, 22);
            cToolStripMenuItem.Text = "Classe";
            // 
            // qualiterToolStripMenuItem
            // 
            qualiterToolStripMenuItem.Name = "qualiterToolStripMenuItem";
            qualiterToolStripMenuItem.Size = new Size(180, 22);
            qualiterToolStripMenuItem.Text = "Qualiter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
    }
}
