namespace ConservatoireMVC
{
    partial class VuePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VuePrincipale));
            this.lstProfesseurs = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesProfesseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSearch_Click = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProfesseurs
            // 
            this.lstProfesseurs.BackColor = System.Drawing.Color.White;
            this.lstProfesseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProfesseurs.ForeColor = System.Drawing.Color.Black;
            this.lstProfesseurs.FormattingEnabled = true;
            this.lstProfesseurs.ItemHeight = 15;
            this.lstProfesseurs.Location = new System.Drawing.Point(41, 172);
            this.lstProfesseurs.Name = "lstProfesseurs";
            this.lstProfesseurs.Size = new System.Drawing.Size(770, 289);
            this.lstProfesseurs.TabIndex = 2;
            this.lstProfesseurs.SelectedIndexChanged += new System.EventHandler(this.lstProfesseurs_SelectedIndexChanged_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(767, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Quitter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 77);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le conservatoire pour tous";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesProfesseursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesProfesseursToolStripMenuItem
            // 
            this.gestionDesProfesseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProfesseurToolStripMenuItem,
            this.modifierUnProfesseurToolStripMenuItem,
            this.supprimerUnProfesseurToolStripMenuItem});
            this.gestionDesProfesseursToolStripMenuItem.Name = "gestionDesProfesseursToolStripMenuItem";
            this.gestionDesProfesseursToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.gestionDesProfesseursToolStripMenuItem.Text = "Gestion des professeurs";
            // 
            // ajouterUnProfesseurToolStripMenuItem
            // 
            this.ajouterUnProfesseurToolStripMenuItem.Name = "ajouterUnProfesseurToolStripMenuItem";
            this.ajouterUnProfesseurToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterUnProfesseurToolStripMenuItem.Text = "Ajouter";
            this.ajouterUnProfesseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProfesseurToolStripMenuItem_Click);
            // 
            // modifierUnProfesseurToolStripMenuItem
            // 
            this.modifierUnProfesseurToolStripMenuItem.Name = "modifierUnProfesseurToolStripMenuItem";
            this.modifierUnProfesseurToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierUnProfesseurToolStripMenuItem.Text = "Modifier";
            this.modifierUnProfesseurToolStripMenuItem.Click += new System.EventHandler(this.modifierUnProfesseurToolStripMenuItem_Click_1);
            // 
            // supprimerUnProfesseurToolStripMenuItem
            // 
            this.supprimerUnProfesseurToolStripMenuItem.Name = "supprimerUnProfesseurToolStripMenuItem";
            this.supprimerUnProfesseurToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerUnProfesseurToolStripMenuItem.Text = "Supprimer";
            this.supprimerUnProfesseurToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnProfesseurToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des professeurs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.button1.Location = new System.Drawing.Point(429, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Consulter les cours du professeur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(107, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Consulter la liste des élèves";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch_Click
            // 
            this.btnSearch_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.btnSearch_Click.Location = new System.Drawing.Point(736, 146);
            this.btnSearch_Click.Name = "btnSearch_Click";
            this.btnSearch_Click.Size = new System.Drawing.Size(75, 20);
            this.btnSearch_Click.TabIndex = 20;
            this.btnSearch_Click.Text = "Rechercher";
            this.btnSearch_Click.UseVisualStyleBackColor = false;
            this.btnSearch_Click.Click += new System.EventHandler(this.btnSearch_Click_Click);
            // 
            // txt_search
            // 
            this.txt_search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_search.Location = new System.Drawing.Point(630, 146);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 19;
            // 
            // VuePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(854, 534);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch_Click);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstProfesseurs);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VuePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conservatoire : Acceuil";
            this.Load += new System.EventHandler(this.VuePrincipale_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstProfesseurs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProfesseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProfesseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnProfesseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnProfesseurToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch_Click;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button3;
    }
}

