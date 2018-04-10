namespace AikidoLog
{
    partial class FrmNewLog
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxAttackUke = new System.Windows.Forms.ComboBox();
            this.cbxImmonilisation = new System.Windows.Forms.ComboBox();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblTechniques = new System.Windows.Forms.Label();
            this.lblAuSol = new System.Windows.Forms.Label();
            this.lblSolDebout = new System.Windows.Forms.Label();
            this.lblTachiwaza = new System.Windows.Forms.Label();
            this.cbxSuwaziWaza = new System.Windows.Forms.ComboBox();
            this.cbxAiHanmiHandachiWaza = new System.Windows.Forms.ComboBox();
            this.cbxTachiWaZa = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblSituation = new System.Windows.Forms.Label();
            this.cbxSituationTravail = new System.Windows.Forms.ComboBox();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.labelrapel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(254, 533);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(12, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date de l\'entrainement :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(138, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // cbxAttackUke
            // 
            this.cbxAttackUke.DropDownWidth = 200;
            this.cbxAttackUke.FormattingEnabled = true;
            this.cbxAttackUke.Items.AddRange(new object[] {
            "   1.1 Coups : atemi - 当て身",
            "        1.1.1 Shomen uchi - 正面打ち",
            "        1.1.2 Yokomen uchi - 横面打ち",
            "        1.1.3 Sokumen uchi - 側面打ち",
            "        1.1.4 Chūdan tsuki - 中段突き",
            "        1.1.5 Jodan tsuki - 上段突き",
            "        1.1.6 Mae geri - 前蹴り",
            "        1.1.7 Mawashi geri - 回し蹴り",
            "    1.2 Saisies : dori - 取り",
            "        1.2.1 Katate dori - 片手取り",
            "        1.2.2 Ryote dori - 両手取り",
            "        1.2.3 Katate ryote dori - 片手両手取り, ou morote dori 諸手取り",
            "        1.2.4 Kata dori - 肩取り",
            "        1.2.5 Ryo kata dori - 両肩取り",
            "        1.2.6 Sode dori - 袖取り",
            "        1.2.7 Muna dori - 胸取り",
            "        1.2.8 Kata dori men uchi - 肩取り面打ち",
            "    1.3 Attaque par l\'arrière : ushiro waza - 後ろ技",
            "        1.3.1 Ushiro katate dori - 後ろ片手取り",
            "        1.3.2 Ushiro hiji dori - 後ろ肘取り",
            "        1.3.3 Ushiro ryo kata dori - 両肩取り",
            "        1.3.4 Katate kubi shime - 片手首絞め",
            "        1.3.5 Eri dori - 襟取り"});
            this.cbxAttackUke.Location = new System.Drawing.Point(191, 71);
            this.cbxAttackUke.Name = "cbxAttackUke";
            this.cbxAttackUke.Size = new System.Drawing.Size(148, 21);
            this.cbxAttackUke.TabIndex = 5;
            // 
            // cbxImmonilisation
            // 
            this.cbxImmonilisation.DropDownWidth = 200;
            this.cbxImmonilisation.FormattingEnabled = true;
            this.cbxImmonilisation.Items.AddRange(new object[] {
            "  1 Ikkyo - 一教",
            "  2 Nikyo - 二教",
            "  3 Sankyo - 三教",
            "  4 Yonkyo - 四教",
            "  5 Gokyo - 五教",
            ""});
            this.cbxImmonilisation.Location = new System.Drawing.Point(191, 97);
            this.cbxImmonilisation.Name = "cbxImmonilisation";
            this.cbxImmonilisation.Size = new System.Drawing.Size(148, 21);
            this.cbxImmonilisation.TabIndex = 6;
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAttack.Location = new System.Drawing.Point(12, 74);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(88, 13);
            this.lblAttack.TabIndex = 7;
            this.lblAttack.Text = "Attaque de Uke :";
            // 
            // lblTechniques
            // 
            this.lblTechniques.AutoSize = true;
            this.lblTechniques.BackColor = System.Drawing.Color.Transparent;
            this.lblTechniques.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTechniques.Location = new System.Drawing.Point(12, 100);
            this.lblTechniques.Name = "lblTechniques";
            this.lblTechniques.Size = new System.Drawing.Size(78, 13);
            this.lblTechniques.TabIndex = 8;
            this.lblTechniques.Text = "Immobilisation :";
            // 
            // lblAuSol
            // 
            this.lblAuSol.AutoSize = true;
            this.lblAuSol.BackColor = System.Drawing.Color.Transparent;
            this.lblAuSol.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAuSol.Location = new System.Drawing.Point(12, 348);
            this.lblAuSol.Name = "lblAuSol";
            this.lblAuSol.Size = new System.Drawing.Size(73, 13);
            this.lblAuSol.TabIndex = 9;
            this.lblAuSol.Text = "Suwari waza :";
            // 
            // lblSolDebout
            // 
            this.lblSolDebout.AutoSize = true;
            this.lblSolDebout.BackColor = System.Drawing.Color.Transparent;
            this.lblSolDebout.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSolDebout.Location = new System.Drawing.Point(12, 370);
            this.lblSolDebout.Name = "lblSolDebout";
            this.lblSolDebout.Size = new System.Drawing.Size(85, 26);
            this.lblSolDebout.TabIndex = 10;
            this.lblSolDebout.Text = "Ai Hanmi \r\nhandachi waza :";
            // 
            // lblTachiwaza
            // 
            this.lblTachiwaza.AutoSize = true;
            this.lblTachiwaza.BackColor = System.Drawing.Color.Transparent;
            this.lblTachiwaza.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTachiwaza.Location = new System.Drawing.Point(12, 405);
            this.lblTachiwaza.Name = "lblTachiwaza";
            this.lblTachiwaza.Size = new System.Drawing.Size(68, 13);
            this.lblTachiwaza.TabIndex = 11;
            this.lblTachiwaza.Text = "Tachi waza :";
            // 
            // cbxSuwaziWaza
            // 
            this.cbxSuwaziWaza.DropDownWidth = 200;
            this.cbxSuwaziWaza.FormattingEnabled = true;
            this.cbxSuwaziWaza.Items.AddRange(new object[] {
            " 3.1 Shomen uchi - 正面打ち",
            " 3.2 Yokomen uchi",
            " 3.3 Katate dori",
            " 3.4 Ryote dori",
            " 3.5 Ryo kata dori"});
            this.cbxSuwaziWaza.Location = new System.Drawing.Point(191, 348);
            this.cbxSuwaziWaza.Name = "cbxSuwaziWaza";
            this.cbxSuwaziWaza.Size = new System.Drawing.Size(142, 21);
            this.cbxSuwaziWaza.TabIndex = 12;
            // 
            // cbxAiHanmiHandachiWaza
            // 
            this.cbxAiHanmiHandachiWaza.DropDownWidth = 200;
            this.cbxAiHanmiHandachiWaza.FormattingEnabled = true;
            this.cbxAiHanmiHandachiWaza.Items.AddRange(new object[] {
            "  1 Katate dori",
            "  2 Ryote dori",
            "  3 Ushiro waza-Ryokata dori"});
            this.cbxAiHanmiHandachiWaza.Location = new System.Drawing.Point(191, 375);
            this.cbxAiHanmiHandachiWaza.Name = "cbxAiHanmiHandachiWaza";
            this.cbxAiHanmiHandachiWaza.Size = new System.Drawing.Size(142, 21);
            this.cbxAiHanmiHandachiWaza.TabIndex = 13;
            // 
            // cbxTachiWaZa
            // 
            this.cbxTachiWaZa.DropDownWidth = 200;
            this.cbxTachiWaZa.FormattingEnabled = true;
            this.cbxTachiWaZa.Items.AddRange(new object[] {
            "1 Aihanmi katate dori",
            "2 Katate dori",
            "3 Kata dori",
            "4 Muna dori",
            "5 Ryote dori",
            "6 Ryokata dori",
            "7 Katate ryote dori",
            "8 Chudan tsuki",
            "9 Jodan tsuki",
            "10 Shomen uchi",
            "11 Yokomen uchi",
            "12 Katadori menuchi",
            "13 Mae geri"});
            this.cbxTachiWaZa.Location = new System.Drawing.Point(191, 402);
            this.cbxTachiWaZa.Name = "cbxTachiWaZa";
            this.cbxTachiWaZa.Size = new System.Drawing.Size(142, 21);
            this.cbxTachiWaZa.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(6, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentaire.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCommentaire.Location = new System.Drawing.Point(12, 432);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(74, 13);
            this.lblCommentaire.TabIndex = 16;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(94, 434);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(239, 87);
            this.txtCommentaire.TabIndex = 17;
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.BackColor = System.Drawing.Color.Transparent;
            this.lblSituation.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSituation.Location = new System.Drawing.Point(12, 47);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(100, 13);
            this.lblSituation.TabIndex = 18;
            this.lblSituation.Text = "Situation de travail :";
            // 
            // cbxSituationTravail
            // 
            this.cbxSituationTravail.FormattingEnabled = true;
            this.cbxSituationTravail.Items.AddRange(new object[] {
            "TACHI WAZA Uke et Tori sont debout",
            "HANMIHANDACHI WAZA Uke est debout, Tori à genoux",
            "SUWARI WAZA Uke et Tori sont à genoux"});
            this.cbxSituationTravail.Location = new System.Drawing.Point(191, 44);
            this.cbxSituationTravail.Name = "cbxSituationTravail";
            this.cbxSituationTravail.Size = new System.Drawing.Size(147, 21);
            this.cbxSituationTravail.TabIndex = 19;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(138, 196);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(200, 20);
            this.dtp2.TabIndex = 20;
            // 
            // labelrapel
            // 
            this.labelrapel.AutoSize = true;
            this.labelrapel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelrapel.Location = new System.Drawing.Point(15, 202);
            this.labelrapel.Name = "labelrapel";
            this.labelrapel.Size = new System.Drawing.Size(50, 13);
            this.labelrapel.TabIndex = 21;
            this.labelrapel.Text = "Rappel : ";
            // 
            // FrmNewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(345, 562);
            this.Controls.Add(this.labelrapel);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.cbxSituationTravail);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxTachiWaZa);
            this.Controls.Add(this.cbxAiHanmiHandachiWaza);
            this.Controls.Add(this.cbxSuwaziWaza);
            this.Controls.Add(this.lblTachiwaza);
            this.Controls.Add(this.lblSolDebout);
            this.Controls.Add(this.lblAuSol);
            this.Controls.Add(this.lblTechniques);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.cbxImmonilisation);
            this.Controls.Add(this.cbxAttackUke);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmNewLog";
            this.ShowIcon = false;
            this.Text = "Nouveau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblTechniques;
        private System.Windows.Forms.Label lblAuSol;
        private System.Windows.Forms.Label lblSolDebout;
        private System.Windows.Forms.Label lblTachiwaza;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblSituation;
        protected System.Windows.Forms.Button btnSave;
        protected System.Windows.Forms.DateTimePicker dateTimePicker;
        protected System.Windows.Forms.ComboBox cbxAttackUke;
        protected System.Windows.Forms.ComboBox cbxImmonilisation;
        protected System.Windows.Forms.ComboBox cbxSuwaziWaza;
        protected System.Windows.Forms.ComboBox cbxAiHanmiHandachiWaza;
        protected System.Windows.Forms.ComboBox cbxTachiWaZa;
        protected System.Windows.Forms.TextBox txtCommentaire;
        protected System.Windows.Forms.ComboBox cbxSituationTravail;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.Label labelrapel;
    }
}