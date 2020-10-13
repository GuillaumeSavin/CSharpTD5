using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetiers
{
    public class Employe : Collaborateur
    {
        static float t1;
        float tarif;
        int nbH;

        static Employe()
        {
            /*Console.WriteLine("Saisir taux des heures supplémentaires employés");
            string s = Console.ReadLine();
            t1 = float.Parse(s);
            Console.WriteLine();*/
            t1 = 40;
        }
        public Employe(string nom, string date, float tarif, int nbH)
            : base(nom, date)
        {
            this.tarif = tarif;
            this.nbH = nbH;
        }

        public override string ToString()
        {
            string retour;
            retour = "Employé : \n" + base.ToString() + "\n\n";
            return retour;
        }


        public override float CalculerSalaire()
        {
            if (nbH > 35) return ((tarif * t1) + tarif) * (nbH - 35) + 35 * (tarif);
            return tarif * nbH;
        }


    }

}
