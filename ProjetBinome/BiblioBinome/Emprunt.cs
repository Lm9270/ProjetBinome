using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioBinome
{
    public class Emprunt
    {
        private DateTime laDate;
        private bool rendu;
        private Utilisateur emprunteur;
        private Livre livre; 

        public Emprunt(Utilisateur emprunteur, Livre livre)
        {
            this.laDate = DateTime.Now;
            this.rendu = false; 
            this.emprunteur = emprunteur;
            this.livre = livre;    
        }

        public DateTime LaDate { get => laDate; set => laDate = value; }
        public bool Rendu { get => rendu; set => rendu = value; }
        public Utilisateur Emprunteur { get => emprunteur; set => emprunteur = value; }
        public Livre Livre { get => livre; set => livre = value; }
    }
}
