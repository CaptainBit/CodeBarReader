namespace Lab3_comm
{
    partial class frmLab2
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
            this.components = new System.ComponentModel.Container();
            this.rbBit = new System.Windows.Forms.RadioButton();
            this.rb2Bit = new System.Windows.Forms.RadioButton();
            this.rbImpair = new System.Windows.Forms.RadioButton();
            this.rbPair = new System.Windows.Forms.RadioButton();
            this.rb7Bit = new System.Windows.Forms.RadioButton();
            this.rb8Bit = new System.Windows.Forms.RadioButton();
            this.rbArret = new System.Windows.Forms.RadioButton();
            this.rbActif = new System.Windows.Forms.RadioButton();
            this.gbArret = new System.Windows.Forms.GroupBox();
            this.gbDonnee = new System.Windows.Forms.GroupBox();
            this.gbParite = new System.Windows.Forms.GroupBox();
            this.gbTransmission = new System.Windows.Forms.GroupBox();
            this.cboVitesse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLire = new System.Windows.Forms.Button();
            this.spPortSerie = new System.IO.Ports.SerialPort(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomArticle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txPrixArticle = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxe = new System.Windows.Forms.TextBox();
            this.txtChckSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQuantiteRestante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbArret.SuspendLayout();
            this.gbDonnee.SuspendLayout();
            this.gbParite.SuspendLayout();
            this.gbTransmission.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBit
            // 
            this.rbBit.AutoSize = true;
            this.rbBit.Location = new System.Drawing.Point(31, 19);
            this.rbBit.Name = "rbBit";
            this.rbBit.Size = new System.Drawing.Size(53, 17);
            this.rbBit.TabIndex = 0;
            this.rbBit.TabStop = true;
            this.rbBit.Text = "Un bit";
            this.rbBit.UseVisualStyleBackColor = true;
            this.rbBit.CheckedChanged += new System.EventHandler(this.rb2Bit_CheckedChanged);
            // 
            // rb2Bit
            // 
            this.rb2Bit.AutoSize = true;
            this.rb2Bit.Location = new System.Drawing.Point(31, 67);
            this.rb2Bit.Name = "rb2Bit";
            this.rb2Bit.Size = new System.Drawing.Size(69, 17);
            this.rb2Bit.TabIndex = 1;
            this.rb2Bit.TabStop = true;
            this.rb2Bit.Text = "Deux bits";
            this.rb2Bit.UseVisualStyleBackColor = true;
            this.rb2Bit.CheckedChanged += new System.EventHandler(this.rb2Bit_CheckedChanged);
            // 
            // rbImpair
            // 
            this.rbImpair.AutoSize = true;
            this.rbImpair.Location = new System.Drawing.Point(15, 62);
            this.rbImpair.Name = "rbImpair";
            this.rbImpair.Size = new System.Drawing.Size(53, 17);
            this.rbImpair.TabIndex = 2;
            this.rbImpair.TabStop = true;
            this.rbImpair.Text = "Impair";
            this.rbImpair.UseVisualStyleBackColor = true;
            this.rbImpair.CheckedChanged += new System.EventHandler(this.rbPair_CheckedChanged);
            // 
            // rbPair
            // 
            this.rbPair.AutoSize = true;
            this.rbPair.Location = new System.Drawing.Point(15, 26);
            this.rbPair.Name = "rbPair";
            this.rbPair.Size = new System.Drawing.Size(43, 17);
            this.rbPair.TabIndex = 3;
            this.rbPair.TabStop = true;
            this.rbPair.Text = "Pair";
            this.rbPair.UseVisualStyleBackColor = true;
            this.rbPair.CheckedChanged += new System.EventHandler(this.rbPair_CheckedChanged);
            // 
            // rb7Bit
            // 
            this.rb7Bit.AutoSize = true;
            this.rb7Bit.Location = new System.Drawing.Point(10, 28);
            this.rb7Bit.Name = "rb7Bit";
            this.rb7Bit.Size = new System.Drawing.Size(50, 17);
            this.rb7Bit.TabIndex = 4;
            this.rb7Bit.TabStop = true;
            this.rb7Bit.Text = "7 bits";
            this.rb7Bit.UseVisualStyleBackColor = true;
            this.rb7Bit.CheckedChanged += new System.EventHandler(this.rb8Bit_CheckedChanged);
            // 
            // rb8Bit
            // 
            this.rb8Bit.AutoSize = true;
            this.rb8Bit.Location = new System.Drawing.Point(10, 64);
            this.rb8Bit.Name = "rb8Bit";
            this.rb8Bit.Size = new System.Drawing.Size(50, 17);
            this.rb8Bit.TabIndex = 5;
            this.rb8Bit.TabStop = true;
            this.rb8Bit.Text = "8 bits";
            this.rb8Bit.UseVisualStyleBackColor = true;
            this.rb8Bit.CheckedChanged += new System.EventHandler(this.rb8Bit_CheckedChanged);
            // 
            // rbArret
            // 
            this.rbArret.AutoSize = true;
            this.rbArret.Location = new System.Drawing.Point(6, 25);
            this.rbArret.Name = "rbArret";
            this.rbArret.Size = new System.Drawing.Size(47, 17);
            this.rbArret.TabIndex = 6;
            this.rbArret.TabStop = true;
            this.rbArret.Text = "Arret";
            this.rbArret.UseVisualStyleBackColor = true;
            this.rbArret.CheckedChanged += new System.EventHandler(this.rbActif_CheckedChanged);
            // 
            // rbActif
            // 
            this.rbActif.AutoSize = true;
            this.rbActif.Location = new System.Drawing.Point(6, 61);
            this.rbActif.Name = "rbActif";
            this.rbActif.Size = new System.Drawing.Size(46, 17);
            this.rbActif.TabIndex = 7;
            this.rbActif.TabStop = true;
            this.rbActif.Text = "Actif";
            this.rbActif.UseVisualStyleBackColor = true;
            this.rbActif.CheckedChanged += new System.EventHandler(this.rbActif_CheckedChanged);
            // 
            // gbArret
            // 
            this.gbArret.Controls.Add(this.rb2Bit);
            this.gbArret.Controls.Add(this.rbBit);
            this.gbArret.Location = new System.Drawing.Point(16, 21);
            this.gbArret.Name = "gbArret";
            this.gbArret.Size = new System.Drawing.Size(148, 118);
            this.gbArret.TabIndex = 8;
            this.gbArret.TabStop = false;
            this.gbArret.Text = "Bits d\'arrêt";
            // 
            // gbDonnee
            // 
            this.gbDonnee.Controls.Add(this.rb8Bit);
            this.gbDonnee.Controls.Add(this.rb7Bit);
            this.gbDonnee.Location = new System.Drawing.Point(170, 25);
            this.gbDonnee.Name = "gbDonnee";
            this.gbDonnee.Size = new System.Drawing.Size(121, 114);
            this.gbDonnee.TabIndex = 9;
            this.gbDonnee.TabStop = false;
            this.gbDonnee.Text = "Octet";
            // 
            // gbParite
            // 
            this.gbParite.Controls.Add(this.rbPair);
            this.gbParite.Controls.Add(this.rbImpair);
            this.gbParite.Location = new System.Drawing.Point(297, 27);
            this.gbParite.Name = "gbParite";
            this.gbParite.Size = new System.Drawing.Size(117, 112);
            this.gbParite.TabIndex = 10;
            this.gbParite.TabStop = false;
            this.gbParite.Text = "Parité";
            // 
            // gbTransmission
            // 
            this.gbTransmission.Controls.Add(this.rbActif);
            this.gbTransmission.Controls.Add(this.rbArret);
            this.gbTransmission.Location = new System.Drawing.Point(420, 28);
            this.gbTransmission.Name = "gbTransmission";
            this.gbTransmission.Size = new System.Drawing.Size(119, 111);
            this.gbTransmission.TabIndex = 11;
            this.gbTransmission.TabStop = false;
            this.gbTransmission.Text = "Activité";
            // 
            // cboVitesse
            // 
            this.cboVitesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVitesse.FormattingEnabled = true;
            this.cboVitesse.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cboVitesse.Location = new System.Drawing.Point(9, 155);
            this.cboVitesse.Name = "cboVitesse";
            this.cboVitesse.Size = new System.Drawing.Size(121, 21);
            this.cboVitesse.TabIndex = 12;
            this.cboVitesse.SelectedValueChanged += new System.EventHandler(this.cboVitesse_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vitesse";
            // 
            // btnLire
            // 
            this.btnLire.Location = new System.Drawing.Point(21, 203);
            this.btnLire.Name = "btnLire";
            this.btnLire.Size = new System.Drawing.Size(87, 31);
            this.btnLire.TabIndex = 14;
            this.btnLire.Text = "Lire";
            this.btnLire.UseVisualStyleBackColor = true;
            this.btnLire.Click += new System.EventHandler(this.btnLire_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(489, 398);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(96, 32);
            this.btnFermer.TabIndex = 19;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbArret);
            this.groupBox1.Controls.Add(this.gbDonnee);
            this.groupBox1.Controls.Add(this.gbParite);
            this.groupBox1.Controls.Add(this.cboVitesse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gbTransmission);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 185);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // txtNomArticle
            // 
            this.txtNomArticle.Location = new System.Drawing.Point(21, 276);
            this.txtNomArticle.Name = "txtNomArticle";
            this.txtNomArticle.ReadOnly = true;
            this.txtNomArticle.Size = new System.Drawing.Size(100, 20);
            this.txtNomArticle.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nom Article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prix Article";
            // 
            // txPrixArticle
            // 
            this.txPrixArticle.Location = new System.Drawing.Point(21, 325);
            this.txPrixArticle.Name = "txPrixArticle";
            this.txPrixArticle.ReadOnly = true;
            this.txPrixArticle.Size = new System.Drawing.Size(100, 20);
            this.txPrixArticle.TabIndex = 24;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(127, 276);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(124, 20);
            this.txtDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Taxe";
            // 
            // txtTaxe
            // 
            this.txtTaxe.Location = new System.Drawing.Point(127, 325);
            this.txtTaxe.Name = "txtTaxe";
            this.txtTaxe.ReadOnly = true;
            this.txtTaxe.Size = new System.Drawing.Size(124, 20);
            this.txtTaxe.TabIndex = 28;
            // 
            // txtChckSum
            // 
            this.txtChckSum.Location = new System.Drawing.Point(259, 276);
            this.txtChckSum.Name = "txtChckSum";
            this.txtChckSum.ReadOnly = true;
            this.txtChckSum.Size = new System.Drawing.Size(100, 20);
            this.txtChckSum.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Check sum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(259, 325);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 32;
            // 
            // txtQuantiteRestante
            // 
            this.txtQuantiteRestante.Location = new System.Drawing.Point(393, 302);
            this.txtQuantiteRestante.Name = "txtQuantiteRestante";
            this.txtQuantiteRestante.ReadOnly = true;
            this.txtQuantiteRestante.Size = new System.Drawing.Size(100, 20);
            this.txtQuantiteRestante.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Quantité restante";
            // 
            // frmLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 463);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantiteRestante);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChckSum);
            this.Controls.Add(this.txtTaxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txPrixArticle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomArticle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnLire);
            this.Name = "frmLab2";
            this.Text = "LienSerie";
            this.gbArret.ResumeLayout(false);
            this.gbArret.PerformLayout();
            this.gbDonnee.ResumeLayout(false);
            this.gbDonnee.PerformLayout();
            this.gbParite.ResumeLayout(false);
            this.gbParite.PerformLayout();
            this.gbTransmission.ResumeLayout(false);
            this.gbTransmission.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBit;
        private System.Windows.Forms.RadioButton rb2Bit;
        private System.Windows.Forms.RadioButton rbImpair;
        private System.Windows.Forms.RadioButton rbPair;
        private System.Windows.Forms.RadioButton rb7Bit;
        private System.Windows.Forms.RadioButton rb8Bit;
        private System.Windows.Forms.RadioButton rbArret;
        private System.Windows.Forms.RadioButton rbActif;
        private System.Windows.Forms.GroupBox gbArret;
        private System.Windows.Forms.GroupBox gbDonnee;
        private System.Windows.Forms.GroupBox gbParite;
        private System.Windows.Forms.GroupBox gbTransmission;
        private System.Windows.Forms.ComboBox cboVitesse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLire;
        private System.IO.Ports.SerialPort spPortSerie;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPrixArticle;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTaxe;
        private System.Windows.Forms.TextBox txtChckSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQuantiteRestante;
        private System.Windows.Forms.Label label8;
    }
}

