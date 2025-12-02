namespace Mission3
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GrpRecherche = new System.Windows.Forms.GroupBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvMedecins = new System.Windows.Forms.DataGridView();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.cboDepartement = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEditNom = new System.Windows.Forms.Label();
            this.labelEditPrenom = new System.Windows.Forms.Label();
            this.labelEditDepartement = new System.Windows.Forms.Label();
            this.labelEditAdresse = new System.Windows.Forms.Label();
            this.labelEditTel = new System.Windows.Forms.Label();
            this.labelEditSpecialite = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            this.GrpRecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrpRecherche);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1439, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion des médecins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GrpRecherche
            // 
            this.GrpRecherche.Controls.Add(this.tableLayoutPanel1);
            this.GrpRecherche.Controls.Add(this.txtNom);
            this.GrpRecherche.Controls.Add(this.dgvMedecins);
            this.GrpRecherche.Controls.Add(this.btnRechercher);
            this.GrpRecherche.Controls.Add(this.cboDepartement);
            this.GrpRecherche.Controls.Add(this.label2);
            this.GrpRecherche.Controls.Add(this.label1);
            this.GrpRecherche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpRecherche.Location = new System.Drawing.Point(3, 3);
            this.GrpRecherche.Name = "GrpRecherche";
            this.GrpRecherche.Size = new System.Drawing.Size(1433, 716);
            this.GrpRecherche.TabIndex = 0;
            this.GrpRecherche.TabStop = false;
            this.GrpRecherche.Text = "Recherche";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(76, 47);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 10;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(370, 208);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 23);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(178, 208);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(3, 208);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // dgvMedecins
            // 
            this.dgvMedecins.AllowUserToAddRows = false;
            this.dgvMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecins.Location = new System.Drawing.Point(6, 93);
            this.dgvMedecins.Name = "dgvMedecins";
            this.dgvMedecins.ReadOnly = true;
            this.dgvMedecins.RowHeadersWidth = 51;
            this.dgvMedecins.RowTemplate.Height = 24;
            this.dgvMedecins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedecins.Size = new System.Drawing.Size(840, 604);
            this.dgvMedecins.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.DarkGray;
            this.btnRechercher.Location = new System.Drawing.Point(529, 48);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(97, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // cboDepartement
            // 
            this.cboDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartement.FormattingEnabled = true;
            this.cboDepartement.Location = new System.Drawing.Point(329, 47);
            this.cboDepartement.MinimumSize = new System.Drawing.Size(4, 0);
            this.cboDepartement.Name = "cboDepartement";
            this.cboDepartement.Size = new System.Drawing.Size(121, 24);
            this.cboDepartement.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Département :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1447, 751);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.74011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.25989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEditNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEditPrenom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEditDepartement, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAjouter, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnModifier, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSupprimer, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelEditAdresse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEditSpecialite, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEditTel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(872, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.16867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.83133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 608);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // labelEditNom
            // 
            this.labelEditNom.AutoSize = true;
            this.labelEditNom.Location = new System.Drawing.Point(3, 0);
            this.labelEditNom.Name = "labelEditNom";
            this.labelEditNom.Size = new System.Drawing.Size(42, 16);
            this.labelEditNom.TabIndex = 10;
            this.labelEditNom.Text = "Nom :";
            // 
            // labelEditPrenom
            // 
            this.labelEditPrenom.AutoSize = true;
            this.labelEditPrenom.Location = new System.Drawing.Point(178, 0);
            this.labelEditPrenom.Name = "labelEditPrenom";
            this.labelEditPrenom.Size = new System.Drawing.Size(60, 16);
            this.labelEditPrenom.TabIndex = 11;
            this.labelEditPrenom.Text = "Prénom :";
            // 
            // labelEditDepartement
            // 
            this.labelEditDepartement.AutoSize = true;
            this.labelEditDepartement.Location = new System.Drawing.Point(370, 0);
            this.labelEditDepartement.Name = "labelEditDepartement";
            this.labelEditDepartement.Size = new System.Drawing.Size(91, 16);
            this.labelEditDepartement.TabIndex = 12;
            this.labelEditDepartement.Text = "Département :";
            // 
            // labelEditAdresse
            // 
            this.labelEditAdresse.AutoSize = true;
            this.labelEditAdresse.Location = new System.Drawing.Point(3, 66);
            this.labelEditAdresse.Name = "labelEditAdresse";
            this.labelEditAdresse.Size = new System.Drawing.Size(64, 16);
            this.labelEditAdresse.TabIndex = 13;
            this.labelEditAdresse.Text = "Adresse :";
            // 
            // labelEditTel
            // 
            this.labelEditTel.AutoSize = true;
            this.labelEditTel.Location = new System.Drawing.Point(178, 66);
            this.labelEditTel.Name = "labelEditTel";
            this.labelEditTel.Size = new System.Drawing.Size(79, 16);
            this.labelEditTel.TabIndex = 14;
            this.labelEditTel.Text = "Téléphone :";
            // 
            // labelEditSpecialite
            // 
            this.labelEditSpecialite.AutoSize = true;
            this.labelEditSpecialite.Location = new System.Drawing.Point(370, 66);
            this.labelEditSpecialite.Name = "labelEditSpecialite";
            this.labelEditSpecialite.Size = new System.Drawing.Size(73, 16);
            this.labelEditSpecialite.TabIndex = 15;
            this.labelEditSpecialite.Text = "Spécialité :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(370, 114);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 751);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.GrpRecherche.ResumeLayout(false);
            this.GrpRecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecins)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox GrpRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepartement;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvMedecins;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEditNom;
        private System.Windows.Forms.Label labelEditPrenom;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEditDepartement;
        private System.Windows.Forms.Label labelEditAdresse;
        private System.Windows.Forms.Label labelEditTel;
        private System.Windows.Forms.Label labelEditSpecialite;
        private System.Windows.Forms.TextBox textBox1;
    }
}

