using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AikidoLog
{
    public partial class FrmNewLog : Form
    {
        public FrmNewLog()
        {
            InitializeComponent();
            DateTime DateDelay = new DateTime();
        }

        private void Ajouter()
        {
            //Find a way to put a counter somewhere in data to add new shit to the arraylist.
            Log_Techniques ZewLog = new Log_Techniques();
            try
            {
                DateTime varDate = dateTimePicker.Value;
                ZewLog.idLogFile = Data.aikidoList.Count;
                ZewLog.date = varDate;
                MessageBox.Show(varDate.ToString());
                ZewLog.situationTravail = cbxSituationTravail.Text;
                ZewLog.attackDeUke = cbxAttackUke.Text;
                ZewLog.immobilisation = cbxImmonilisation.Text;
                ZewLog.suwaziwaza = cbxSuwaziWaza.Text;
                ZewLog.aiHanMiHandachiWaza = cbxAiHanmiHandachiWaza.Text;
                ZewLog.tachiWaZa = cbxTachiWaZa.Text;
                ZewLog.commentaire = txtCommentaire.Text;
                Data.aikidoList.Add(ZewLog);
                //testing
                DateTime varDateDelay = dtp2.Value;

                ZewLog.datedelay = varDateDelay;
                MessageBox.Show("The email will be sent : " + varDateDelay.ToString());

                // ca marche pas ton truc !!!!!!!! :p
            }
            catch (Exception ex)
            {
                ZewLog = null;

                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de logfile");
                return;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Ajouter();
            this.Close();
        }
    }
}
