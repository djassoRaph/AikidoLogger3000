using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoLog
{
    public class Log_Techniques
    {
        ///Get set list.
        ///

        ///<summary>List des techniques et methodes de travail utilisé dans les 
        ///entrainements et sur les formNew .</summary>
        ///
        private static Int32 IdLogFile;
        public int idLogFile { get => IdLogFile; set => IdLogFile = value; }

        private DateTime Date;
        public DateTime date { get => Date; set => Date = value; }

        private String SituationTravail;
        public string situationTravail { get => SituationTravail; set => SituationTravail = value; }

        private String AttaqueDeUke;
        public string attackDeUke { get => AttaqueDeUke; set => AttaqueDeUke = value; }

        private String Immobilisation;
        public string immobilisation { get => Immobilisation; set => Immobilisation = value; }

        private String SuwariWaza;
        public string suwaziwaza { get => SuwariWaza; set => SuwariWaza = value; }

        private String AiHanMiHandachiWaZa;
        public string aiHanMiHandachiWaza { get => AiHanMiHandachiWaZa; set => AiHanMiHandachiWaZa = value; }

        private String TachiWaZa;
        public string tachiWaZa { get => TachiWaZa; set => TachiWaZa = value; }

        public String Commentaire;
        public string commentaire { get => Commentaire; set => Commentaire = value; }

        // currently undertesting for delay experience

        public DateTime DateDelay;

        public DateTime datedelay { get => DateDelay; set => DateDelay = value; }


        public string Sendemaildata()
        {
            return $"Le {Date},\nJ'ai travaillé en {SituationTravail}, \nUke saisie de mangiere {AttaqueDeUke}. \nL'immobilisation : {Immobilisation}.\nEt des commentaires : {Commentaire}";
        }


    }


}
