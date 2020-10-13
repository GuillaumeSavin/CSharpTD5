using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetiers
{
    public class Manager : Collaborateur
    {
        float salB;
        float prime;
        public Manager(string nom, string date, float salB, float prime)
            : base(nom, date)
        {
            this.salB = salB; this.prime = prime;
        }



        public override string ToString()
        {
            string retour;
            retour = "Manager : \n" + base.ToString() + "\n\n";
            return retour;
        }

        public override float CalculerSalaire()
        {

            return salB + prime;
        }

    }

}
