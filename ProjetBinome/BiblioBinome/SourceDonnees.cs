using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioBinome
{
    public class SourceDonnees
    {
        private List<Emprunt> emprunts;
        private List<Livre> livres;
        private List<Utilisateur> utilisateurs;

        public SourceDonnees()
        {
            utilisateurs = new List<Utilisateur>();
            utilisateurs.Add(new Utilisateur(1, "Neymar", "Jean"));
            utilisateurs.Add(new Utilisateur(2, "Bou", "Carrie"));
            utilisateurs.Add(new Utilisateur(3, "Rogne", "Olive"));

            livres = new List<Livre>();
            livres.Add(new Livre(1, "978-2070368228", "1984", "Georges Orwell"));
            livres.Add(new Livre(2, "978-2743615871", "Le Dahlia Noir", "James Ellroy")); livres.Add(new Livre(3, "978-2743602680", "LA Confidential", "James Ellroy")); livres.Add(new Livre(4, "978-2266149846", "Le Désert des Tartares",
            "Dino Buzzati"));
            emprunts = new List<Emprunt>();
            Emprunt emprunt = new Emprunt(utilisateurs[0], livres[1]);
            emprunt.Rendu = true;
            emprunts.Add(emprunt);
            emprunt = new Emprunt(utilisateurs[0], livres[2]);
            emprunts.Add(emprunt);
            emprunt = new Emprunt(utilisateurs[2], livres[1]); emprunts.Add(emprunt);
        }

        public List<Emprunt> Emprunts { get => emprunts; set => emprunts = value; }
        public List<Livre> Livres { get => livres; set => livres = value; }
        public List<Utilisateur> Utilisateurs { get => utilisateurs; set => utilisateurs = value; }
   
        public void AjouterEmprunt(Utilisateur unUtilisateur, Livre unLivre)
        {
            Emprunt emprunt = new Emprunt(unUtilisateur, unLivre); 
        }

        public void AjouterLivre(int unld, string unISBN, string unTitre, string unAuteur)
        {
            Livre livre = new Livre(unld, unISBN, unTitre, unAuteur);
        }

        public void AjouterUtilisateur(int unld, string unNom, string unPrenom)
        {
            Utilisateur utilisateur = new Utilisateur(unld, unNom, unPrenom);
        }

        public void EnregistrerRetour(Emprunt unEmprunt)
        {
            unEmprunt.LaDate = DateTime.Now;
        }

        public List<Emprunt> GetEmpruntsEnCours()
        {
            foreach(Livre livre in livres)
            {
                foreach (Emprunt emprunt in emprunts)
                {
                    if (livre.Id == emprunt.Livre.Id)
                    {
                        emprunts.Add(emprunt);
                    }
                }
            }

            return emprunts; 

        }


        public List<Livre> getLivresEmpruntables()
        {
            return livres;

        }

    }
}
