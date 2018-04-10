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
    public partial class FrmListLog : Form
    {
        public FrmListLog()
        {
            InitializeComponent();
            MethodeAffichageListLogAikido();
        }

        private void MethodeAffichageListLogAikido()

        {
            DataTable dt = new DataTable(); // Declaration
            DataRow dr; // Declaration

            Int32 i; // Declaration
            dt.Columns.Add(new DataColumn("Date", typeof(System.String))); // 
            dt.Columns.Add(new DataColumn("Situation de Travail", typeof(System.String))); // 
            dt.Columns.Add(new DataColumn("Attack de Uke", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Immobilisation", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Suwari waza", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ai Hanmi handachi waza", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Tachi waza", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Commentaire", typeof(System.String)));

            //testing
            dt.Columns.Add(new DataColumn("Send date", typeof(System.DateTime))); // testing

            //Fin de declaration

            for (i = 0; i < Data.aikidoList.Count; i++) //
            {
                //Wtf
                dr = dt.NewRow();
                //Please comment affectation 

                dr[0] = ((Log_Techniques)(Data.aikidoList[i])).date;
                dr[1] = ((Log_Techniques)(Data.aikidoList[i])).situationTravail;
                dr[2] = ((Log_Techniques)(Data.aikidoList[i])).attackDeUke;
                dr[3] = ((Log_Techniques)(Data.aikidoList[i])).immobilisation;
                dr[4] = ((Log_Techniques)(Data.aikidoList[i])).suwaziwaza;
                dr[5] = ((Log_Techniques)(Data.aikidoList[i])).aiHanMiHandachiWaza;
                dr[6] = ((Log_Techniques)(Data.aikidoList[i])).tachiWaZa;
                dr[7] = ((Log_Techniques)(Data.aikidoList[i])).commentaire;
                dr[8] = ((Log_Techniques)(Data.aikidoList[i])).datedelay;

                dt.Rows.Add(dr);
            } // End of FOR

            this.dgrdList.DataSource = dt;
            this.dgrdList.DataSource = dt.DefaultView;
            this.dgrdList.Refresh();

            dt = null;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction.");
        }
    }
}
