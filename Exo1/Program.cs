using System;
using System.Collections.Generic;
using ClassesMetiers;
namespace Exo1
{
    public class Prog
    {
        public static void Main()
        {
            TabCollaborateur tab = new TabCollaborateur();

            try
            {
                Employe e1 = new Employe("Lejaune", "13051956", 20, 30);
                Employe e2 = new Employe("LeBlanc", "20051970", 15, 100);
                Manager m1 = new Manager("LeRouge", "14011998", 2500, 150);
                Manager m2 = new Manager("LeVert", "29101987", 3000, 200);
                Commercial c1 = new Commercial("LeNoir", "29011987", 4000, 30000);
                Commercial c2 = new Commercial("LeViolet", "29011987", 3000, 30000);
                Employe e3 = new Employe("ErrorFormat", "12121850", 10, 10);
                tab.Add(c1);
                tab.Add(e1);
                tab.Add(m1);
                tab.Add(e2);
                tab.Add(m2);
                tab.Add(c2);
                Console.WriteLine("COLLABORATEUR AYANT PLUS HAUT SALAIRE");
                Console.WriteLine(tab.PlusHautSal());
                Console.WriteLine("EMPLOYE AYANT PLUS HAUT SALAIRE");
                Console.WriteLine(tab.PlusHautSal("Employe"));
                Console.WriteLine("MANAGER AYANT PLUS HAUT SALAIRE");
                Console.WriteLine(tab.PlusHautSal("Manager"));
                Console.WriteLine("COMMERCIAL AYANT PLUS HAUT SALAIRE");
                Console.WriteLine(tab.PlusHautSal("Commercial"));
                Console.WriteLine("Le Plus Vieux ");
                Console.WriteLine(tab.PlusVieux());
                Console.WriteLine("Le Plus Vieux des Manager ");
                Console.WriteLine(tab.PlusVieux("Manager"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
