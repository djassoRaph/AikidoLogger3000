namespace AikidoLog
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnNewLog = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkbx_Email = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnNewLog
            // 
            this.btnNewLog.Location = new System.Drawing.Point(23, 30);
            this.btnNewLog.Name = "btnNewLog";
            this.btnNewLog.Size = new System.Drawing.Size(75, 23);
            this.btnNewLog.TabIndex = 0;
            this.btnNewLog.Text = "Nouveau Log";
            this.btnNewLog.UseVisualStyleBackColor = true;
            this.btnNewLog.Click += new System.EventHandler(this.btnNewLog_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(252, 30);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(75, 23);
            this.btnViewLog.TabIndex = 1;
            this.btnViewLog.Text = "Voir Log";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(217, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Quitter | 出処";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkbx_Email
            // 
            this.chkbx_Email.AutoSize = true;
            this.chkbx_Email.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_Email.Location = new System.Drawing.Point(23, 352);
            this.chkbx_Email.Name = "chkbx_Email";
            this.chkbx_Email.Size = new System.Drawing.Size(133, 17);
            this.chkbx_Email.TabIndex = 3;
            this.chkbx_Email.Text = "Envoyez moi un rappel";
            this.chkbx_Email.UseVisualStyleBackColor = false;
            this.chkbx_Email.CheckedChanged += new System.EventHandler(this.chkbx_Email_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Envoyer mail - future timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(349, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkbx_Email);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnNewLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 500);
            this.MinimumSize = new System.Drawing.Size(365, 500);
            this.Name = "FrmMain";
            this.Text = "Aikido Training Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewLog;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkbx_Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

