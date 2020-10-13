using System;
using System.Collections;

namespace ClassesMetiers
{
    public abstract class Collaborateur: IComparable
    {
        string nom;
        string dateNaissance;
        public Collaborateur(string nom, string date)
        {
            this.nom = nom;
            
            if (date.Length > 8 || date.Length < 8)
            {
                throw new ExceptionDateFormatInvalid(date);
            }

            int jour = int.Parse(date.Substring(0, 2));

            if (jour <= 0 || jour > 31)
            {
                throw new ExceptionDateDayInvalid(jour);
            }
            int mois = int.Parse(date.Substring(2, 2));
            
            if (mois <= 0 || mois > 12)
            {
                throw new ExceptionDateMounthInvalid(mois);
            }
            int annee = int.Parse(date.Substring(4, 4));
            
            if (annee < 1850 || annee > DateTime.Now.Year)
            {
                throw new ExceptionDateYearInvalid(annee);
            }
            
            dateNaissance = date;
        }
        public override string ToString()
        {
            return "Nom : " + nom +"\n" + "Date de naissance : "+dateNaissance + "\n" + "Salaire : " + CalculerSalaire();
           
        }
        public int Age()
        {
            DateTime date = DateTime.Now;
            string s = dateNaissance.Substring(4, dateNaissance.Length-4);
            return date.Year - Int32.Parse(s);
        }

        public string Nom
        {
            get{ return nom;}
        }

        public string DateNaissance
        {
            get { return dateNaissance;}
        }
       
        public abstract float CalculerSalaire();
        public Collaborateur PlusHautSal(Collaborateur i)
        {
            if (i.CalculerSalaire() > CalculerSalaire())
                return i;
            else return this;
        }

        public int CompareTo(object O)
        {
            Collaborateur c = (Collaborateur)O;
            return this.Age().CompareTo(c.Age());
            
        }


    }


    public class TriSalaire : IComparer
    {
        public int Compare(Object o1, Object o2)
        {
            Collaborateur c1 = (Collaborateur)o1;
            Collaborateur c2 = (Collaborateur)o2;
            return c1.CalculerSalaire().CompareTo(c2.CalculerSalaire());
        }
    }

 
  
}
