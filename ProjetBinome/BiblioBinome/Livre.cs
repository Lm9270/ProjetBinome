using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioBinome
{
    public class Livre
    {
        private int id;
        private string isbn;
        private string titre;
        private string auteur;

        public Livre(int id, string isbn, string titre, string auteur)
        {
            this.id = id;
            this.isbn = isbn;
            this.titre = titre;
            this.auteur = auteur;
        }

        public string Auteur { get => auteur; set => auteur = value; }
        public int Id { get => id; set => id = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Titre { get => titre; set => titre = value; }
    }

}
