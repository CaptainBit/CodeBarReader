using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Lab3_comm
{
    public class CTrame
    {
        //Variables privées
        private string TrameRecu;
        private string DateTrame;
        private long PositionFichier;
        private int Inventaire;
        //Variables publiques
        public string Checksum;
        public readonly double Taxe = 0.15;
        public double Prix;
        public DateTime Date;
        public bool Verif;
        public int QuantiteRestante;
        public string NomArticle;
      
        public string ProprioNomArticle { get { return NomArticle; } }
        //Constructeur Avec Surcharge
        public CTrame(string Trame)
        {

            int Indice = 0;
            int Index = 0;
            int Islash = 0;
            //Trame Recu
            TrameRecu = Trame;
            File.AppendAllText("TrameRecu.txt", Trame + Environment.NewLine);
            //Trame pas importante
            while (Trame[Indice] != 'B')
            {
                Indice++;
            }
            Indice++;
            //Reste de La trame
            Index = Indice;
            while (Indice < Index + 6)
            {
                while (Islash < 2)
                {

                    DateTrame = DateTrame + Trame[Indice];
                    Islash++;
                    Indice++;
                }
                if(Indice != Index + 6)
                {
                    DateTrame = DateTrame + "/";
                }
                Islash = 0;
            }
            Index = Indice + 6;
            DateTrame = DateTrame + " ";
            Islash = 0;
            while (Indice < Index)
            {
                while (Islash < 2)
                {

                    DateTrame = DateTrame + Trame[Indice];
                    Islash++;
                    Indice++;
                }
                if (Indice != Index )
                {
                    DateTrame = DateTrame + ":";
                }
                Islash = 0;
            }
            while (Trame[Indice] != ',')
            {
                Indice++;
            }
            Indice++;
            while (Trame[Indice] != ' ')
            {
                NomArticle += Trame[Indice];
                Indice++;
            }
            while (Trame[Indice] != ',')
                Indice++;
            Indice++;
            Checksum = Checksum + Trame[Indice] + Trame[Indice + 1];
            Date = new DateTime(GetTemps(DateTrame[6] , DateTrame[7]),
                GetTemps(DateTrame[0] , DateTrame[1]),
                GetTemps(DateTrame[3] , DateTrame[4]),
                GetTemps(DateTrame[9] , DateTrame[10]),
                GetTemps(DateTrame[12] , DateTrame[13]),
                GetTemps(DateTrame[15] , DateTrame[16]));
            if(DateVerif(Date) == false )
            {
                Verif = false;
            }
            else
            {
                Int32.TryParse(trouverItem(NomArticle, "Inventaire.txt"), out Inventaire);
                double.TryParse(trouverItem(NomArticle, "Produit.txt"), out Prix);
                SoustraireItem(NomArticle, "Inventaire.txt", 1);
                Verif = true;
            }
        }

      
        public bool FindChecksum(string Donnee, string Checksum)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(Donnee);
            int Intchecksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                Intchecksum += chData;
            }
            string Total = Intchecksum.ToString("X");
            //comparaison
            string Checked = (Total[Total.Length - 2] + Total[Total.Length - 1]).ToString("X2");
            if(Checked == Checksum)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public bool DateVerif(DateTime Date)
        {
            if (Date.Hour < 8 || Date.Hour > 17 ||( (Date.Day < 3 || Date.Day > 24 ) &&( Date.Month == 12 || Date.Month == 1)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private string trouverItem(string donnee, string emplacement)
        {
            StreamReader sr;
            string Lecture;
            int i;
            string inventaire = string.Empty;
            string item = string.Empty;

            sr = new StreamReader(emplacement);

            while (sr.EndOfStream == false && item != donnee)
            {
                Lecture = sr.ReadLine();
                i = 0;
                item = string.Empty;

                while (Lecture[i] != ',' && i < 40)
                {
                    item += Lecture[i];
                    i++;
                }
                if (item == donnee)
                {
                    inventaire = Lecture[i + 1].ToString() + Lecture[i + 2].ToString();
                }
            }
            PositionFichier = sr.BaseStream.Position;
            sr.Close();
            return inventaire;
        }
        public bool SoustraireItem(string donnee, string emplacement, int Nb)
        {
            StreamReader sr;
            int i = 0;
            int NbRestant;

            string inventaire = string.Empty;
            string item = string.Empty;
            NbRestant = Inventaire - Nb;
            string NbRestantS = NbRestant.ToString();
            string InventaireS = Inventaire.ToString();
            if (NbRestant > 0)
            {
                StreamReader r = new StreamReader(emplacement);
                string Texte = r.ReadToEnd();
                string article = "";
                r.Close();
                while(i < Texte.Length && article != NomArticle )
                {
                    article = "";
                    while (Texte[i] != ',')
                    {
                        article = article + Texte[i];
                        i++;
                    }
                    i++;
                }
                Texte = Texte.Remove(i, 2);
                Texte = Texte.Insert(i, NbRestantS);
 
                StreamWriter sw = new StreamWriter(emplacement);
                sw.Write(Texte);
                sw.Close();
                QuantiteRestante = NbRestant;
                return true;
            }
            else
            {
                return false;
            }

          
        }

        private int GetTemps(char DateC, char DateD)
        {
            int i;
            Int32.TryParse((DateC + DateD.ToString()), out i);
            return i;
        }
    }
}
