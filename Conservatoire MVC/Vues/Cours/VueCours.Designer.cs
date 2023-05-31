namespace ConservatoireMVC.Vues
{
    partial class VueCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VueCours));
            this.label2 = new System.Windows.Forms.Label();
            this.listeCours = new System.Windows.Forms.ListView();
            this.Intitulé = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Heure_Début = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Heure_Fin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.nom_Eleve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prénom_Eleve = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_Etudiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Téléphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des cours du professeur :";
            // 
            // listeCours
            // 
            this.listeCours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Intitulé,
            this.Date,
            this.Heure_Début,
            this.Heure_Fin});
            this.listeCours.HideSelection = false;
            this.listeCours.Location = new System.Drawing.Point(19, 168);
            this.listeCours.Name = "listeCours";
            this.listeCours.Size = new System.Drawing.Size(496, 289);
            this.listeCours.TabIndex = 16;
            this.listeCours.UseCompatibleStateImageBehavior = false;
            this.listeCours.View = System.Windows.Forms.View.Details;
            this.listeCours.SelectedIndexChanged += new System.EventHandler(this.listeCours_SelectedIndexChanged);
            // 
            // Intitulé
            // 
            this.Intitulé.Text = "Intitulé";
            this.Intitulé.Width = 115;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date.Width = 93;
            // 
            // Heure_Début
            // 
            this.Heure_Début.Text = "Heure de début";
            this.Heure_Début.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Heure_Début.Width = 124;
            // 
            // Heure_Fin
            // 
            this.Heure_Fin.Text = "Heure de fin";
            this.Heure_Fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Heure_Fin.Width = 74;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom_Eleve,
            this.prénom_Eleve,
            this.N_Etudiant,
            this.Email,
            this.Téléphone});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(552, 168);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(491, 289);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // nom_Eleve
            // 
            this.nom_Eleve.Text = "Nom";
            this.nom_Eleve.Width = 88;
            // 
            // prénom_Eleve
            // 
            this.prénom_Eleve.Text = "Prénom";
            this.prénom_Eleve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prénom_Eleve.Width = 93;
            // 
            // N_Etudiant
            // 
            this.N_Etudiant.Text = "N_Etudiant";
            this.N_Etudiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N_Etudiant.Width = 74;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 117;
            // 
            // Téléphone
            // 
            this.Téléphone.Text = "Téléphone";
            this.Téléphone.Width = 112;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Quitter l\'application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(968, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Retour";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Note : Veuillez sélectionner un intitulé pour obtenir la liste des élèves inscrit" + "s à un cours.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 77);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le conservatoire pour tous";
            // 
            // VueCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1057, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listeCours);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VueCours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conservatoire : Liste des cours d\'un professeur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listeCours;
        private System.Windows.Forms.ColumnHeader Intitulé;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Heure_Début;
        private System.Windows.Forms.ColumnHeader Heure_Fin;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader nom_Eleve;
        private System.Windows.Forms.ColumnHeader prénom_Eleve;
        private System.Windows.Forms.ColumnHeader N_Etudiant;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader Téléphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}