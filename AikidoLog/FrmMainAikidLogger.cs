using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AikidoLog
{
    public partial class FrmMain : Form
    {

        protected FrmNewLog frmNew;
        protected FrmListLog frmList;
        public FrmMain()
        {
            InitializeComponent();
        }


        private void CheckEmailAndSend()
        {
            if (chkbx_Email.Checked)
            {
                try
                {
                    Log_Techniques Temp = Data.aikidoList[Data.aikidoList.Count - 1];
                    Tools.SendEmail("raphaelreck@gmail.com", "Resumé du cours précédent", Temp.Sendemaildata());
                }
                catch (Exception ex)
                {

                    chkbx_Email = null;

                    MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de logfile");
                    return;
                }
                finally
                {


                }

            }
        }

        private void btnNewLog_Click(object sender, EventArgs e)
        {
            FrmNewLog frmNew = new FrmNewLog();
            frmNew.Show();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            FrmListLog frmList = new FrmListLog();
            frmList.Show();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Es-tu sur de vouloir quitter?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                btnNewLog.Select();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckEmailAndSend();


        }

        private void chkbx_Email_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
