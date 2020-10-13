using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClassesMetiers
{
    public class TabCollaborateur : ArrayList
    {
        public Collaborateur PlusHautSal(string type = "")
        {
            Collaborateur c = null; // pour gérer tableau vide
            TabCollaborateur tab = new TabCollaborateur();

            if (type.Equals("") && this.Count!=0)
            {
                // recopier le tableau si on ne veut pas le modifier
                Sort(new TriSalaire());
                c = (Collaborateur)this[Count - 1];
                
            }
            
            foreach (Collaborateur e in this)
            {
                if (e.GetType().Name.Equals(type))
                {
                    tab.Add(e);
                }
            }
        
            if (tab.Count != 0)
            {
                tab.Sort(new TriSalaire()); // factoriser le tri
                c = (Collaborateur)tab[tab.Count - 1];
                
            }
            return c;

        }

        public Collaborateur PlusVieux(string type = "")
        {
            Collaborateur c = null; // pour gérer tableau vide
            TabCollaborateur tab = new TabCollaborateur();

            if (type.Equals("") & Count != 0)
            {
                // recopier le tableau si on ne veut pas le modifier
                Sort();
                c = (Collaborateur)this[Count - 1];

            }

            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].GetType().Name.Equals(type))
                {
                    tab.Add(this[i]);
                }
            }


            if (tab.Count != 0)
            {
                tab.Sort();
                c = (Collaborateur)tab[tab.Count - 1];

            }
            return c;

        }
 
    }
}


