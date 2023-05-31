namespace ConservatoireMVC.Vues
{
    partial class EleveView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleveView));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lstEleves = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesProfesseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEleveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnEleveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnEleveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesCotisations202324ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch_Click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "Liste des élèves";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 77);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 77);
            this.panel2.TabIndex = 7;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(756, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstEleves
            // 
            this.lstEleves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEleves.FormattingEnabled = true;
            this.lstEleves.ItemHeight = 15;
            this.lstEleves.Location = new System.Drawing.Point(30, 186);
            this.lstEleves.Name = "lstEleves";
            this.lstEleves.Size = new System.Drawing.Size(770, 289);
            this.lstEleves.TabIndex = 11;
            this.lstEleves.SelectedIndexChanged += new System.EventHandler(this.lstEleves_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesProfesseursToolStripMenuItem,
            this.cotisationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesProfesseursToolStripMenuItem
            // 
            this.gestionDesProfesseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnEleveToolStripMenuItem,
            this.modifierUnEleveToolStripMenuItem,
            this.supprimerUnEleveToolStripMenuItem});
            this.gestionDesProfesseursToolStripMenuItem.Name = "gestionDesProfesseursToolStripMenuItem";
            this.gestionDesProfesseursToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.gestionDesProfesseursToolStripMenuItem.Text = "Gestion des élèves";
            // 
            // ajouterUnEleveToolStripMenuItem
            // 
            this.ajouterUnEleveToolStripMenuItem.Name = "ajouterUnEleveToolStripMenuItem";
            this.ajouterUnEleveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterUnEleveToolStripMenuItem.Text = "Ajouter";
            this.ajouterUnEleveToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEleveToolStripMenuItem_Click);
            // 
            // modifierUnEleveToolStripMenuItem
            // 
            this.modifierUnEleveToolStripMenuItem.Name = "modifierUnEleveToolStripMenuItem";
            this.modifierUnEleveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierUnEleveToolStripMenuItem.Text = "Modifier";
            this.modifierUnEleveToolStripMenuItem.Click += new System.EventHandler(this.modifierUnEleveToolStripMenuItem_Click);
            // 
            // supprimerUnEleveToolStripMenuItem
            // 
            this.supprimerUnEleveToolStripMenuItem.Name = "supprimerUnEleveToolStripMenuItem";
            this.supprimerUnEleveToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerUnEleveToolStripMenuItem.Text = "Supprimer";
            this.supprimerUnEleveToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnEleveToolStripMenuItem_Click);
            // 
            // cotisationToolStripMenuItem
            // 
            this.cotisationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesCotisations202324ToolStripMenuItem});
            this.cotisationToolStripMenuItem.Name = "cotisationToolStripMenuItem";
            this.cotisationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cotisationToolStripMenuItem.Text = "Cotisation";
            // 
            // gérerLesCotisations202324ToolStripMenuItem
            // 
            this.gérerLesCotisations202324ToolStripMenuItem.Name = "gérerLesCotisations202324ToolStripMenuItem";
            this.gérerLesCotisations202324ToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gérerLesCotisations202324ToolStripMenuItem.Text = "Gérer les cotisations 2023-24";
            this.gérerLesCotisations202324ToolStripMenuItem.Click += new System.EventHandler(this.gérerLesCotisations202324ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Quitter l\'application";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_search
            // 
            this.txt_search.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_search.Location = new System.Drawing.Point(611, 153);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 17;
            // 
            // btnSearch_Click
            // 
            this.btnSearch_Click.Location = new System.Drawing.Point(717, 153);
            this.btnSearch_Click.Name = "btnSearch_Click";
            this.btnSearch_Click.Size = new System.Drawing.Size(75, 20);
            this.btnSearch_Click.TabIndex = 18;
            this.btnSearch_Click.Text = "Rechercher";
            this.btnSearch_Click.UseVisualStyleBackColor = true;
            this.btnSearch_Click.Click += new System.EventHandler(this.btnSearch_Click_Click);
            // 
            // EleveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(843, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch_Click);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lstEleves);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EleveView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conservatoire : Liste des élèves";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstEleves;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProfesseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEleveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnEleveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnEleveToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cotisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesCotisations202324ToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch_Click;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}