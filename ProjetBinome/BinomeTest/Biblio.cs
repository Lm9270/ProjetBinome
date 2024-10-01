using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BiblioBinome;

namespace BinomeTest
{
    internal class Biblio
    {
        static void Main(string[] args)
        {

            SourceDonnees sourceDonnees = new SourceDonnees();

            string numeroMenu = "";

            while (numeroMenu != "8")
            {
                Console.WriteLine(
                "------------------------------------------------ \n" +
                "1. Affichage de la liste des utilisateurs\r\n" +
                "2. Affichage de la liste des livres\r\n" +
                "3. Affichage des emprunts en cours (livres non rendus)\r\n" +
                "4. Ajout d'un nouvel utilisateur\r\n" +
                "5. Ajout d'un nouveau livre\r\n" +
                "6. Emprunt d'un livre par un utilisateur\r\n" +
                "7. Retour d'un livre emprunté\r\n" +
                "8. Fin de l’application");

                Console.Write("\n\nVeuillez saisir un nombre : ");
                numeroMenu = Console.ReadLine();

                // Afficher les utilisateurs -- Aymen 
                void afficherUtilisateur()
                {
                    foreach (Utilisateur utilisateur in sourceDonnees.Utilisateurs)
                    {
                        Console.WriteLine(utilisateur.Nom + " " + utilisateur.Prenom);
                    }
                }

                ///Aymen Afficher Livre
                void afficherLivre()
                {
                    foreach (Livre livre in sourceDonnees.Livres)
                    {
                        Console.WriteLine(livre.Id + " ----- " + livre.Isbn + " ------ " + livre.Titre + " " + livre.Auteur);
                    }
                }

                ///Aymen Afficher Emprunts en cours
                void afficherEmprunt()
                {
                    if (sourceDonnees.Emprunts.Count > 0) { 
                        foreach (Emprunt emprunt in sourceDonnees.GetEmpruntsEnCours())
                        {
                            if (emprunt.Rendu == false)
                            {
                                Console.WriteLine(emprunt.LaDate + " ----- " + emprunt.Rendu + " ------ " + emprunt.Emprunteur.Nom + " " + emprunt.Livre.Titre);
                            }
                        }
                    } else 
                    {
                        Console.WriteLine("Aucun emprunts en cours"); 
                    }
                }

                // Ajouter un utilisateur Liam

                void ajouterUtilisateur()
                {
                    Console.WriteLine("Id : ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Prenom : ");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Nom : ");
                    string nom = Console.ReadLine();

                    Utilisateur nouvelutilisateur = new Utilisateur(id, nom, prenom);
                    sourceDonnees.Utilisateurs.Add(nouvelutilisateur);

                }

                // Ajouter un Livre Liam

                void ajouterLivre()
                {

                    Console.WriteLine("id : ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("ISBN : ");
                    string isbn = Console.ReadLine();

                    Console.WriteLine("Titre : ");
                    string titre = Console.ReadLine();

                    Console.WriteLine("Auteur : ");
                    string auteur = Console.ReadLine();

                    Livre nouveauLivre = new Livre(id, isbn, titre, auteur);
                    sourceDonnees.Livres.Add(nouveauLivre);

                }

                // Ajouter un emprunt -- Liam : 
                
                void ajouterEmprunt()
                {
                    Console.WriteLine("Numéro d'utilisateur : ");
                    int idUtilisateur = int.Parse(Console.ReadLine());

                    foreach(Utilisateur utilisateur in sourceDonnees.Utilisateurs)
                    {
                        if (utilisateur.Id ==  idUtilisateur)
                        {
                            Console.WriteLine("Numéro du livre a emprunter : ");
                            int idLivre = int.Parse(Console.ReadLine());

                            foreach(Livre livre in sourceDonnees.Livres)
                            {
                                if (livre.Id == idLivre)
                                {
                                    Emprunt nouvelEmprunt = new Emprunt(utilisateur, livre);
                                }
                            }
                        }
                    }

                }

                switch (numeroMenu)
                {
                    case "1":
                        afficherUtilisateur();
                        break;

                    case "2":
                        afficherLivre();
                        break;
                    case "3":
                        afficherEmprunt();
                        break;

                    case "4":
                        ajouterUtilisateur();
                        break;

                    case "5":
                        ajouterLivre();
                        break;

                    case "6":
                        ajouterEmprunt();
                        break;



                    case "8":

                        break;


                }
            }
        }
    }
}
