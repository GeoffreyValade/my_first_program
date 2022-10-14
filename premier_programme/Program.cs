using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace premier_programme
{
    internal class Program
    {

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")

            {
                Console.Write("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur : le nom ne doit pas être vide.");

                }

            }
            return nom; 
        }


        static int DemanderAge(string nom)
        {
            int age_num = 0;

            while (age_num <= 0)
            {
                //Exemple de boucle while (boucle "tant que...")
                Console.Write(nom + ", quel est ton âge ? ");
                string age_str = Console.ReadLine();

                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : l'âge doit être positif.");

                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : 0 n'est pas un âge valide.");
                    }

                }
                catch
                {
                    Console.WriteLine("Erreur : veuillez rentrer des chiffres.");
                }
            }
            return age_num;
        }

        static void AfficherInfosPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", et vous avez " + age + " ans.");
            Console.WriteLine("bientôt vous aurez " + (age + 1) + " ans.");

            if (age == 18)
            {
                Console.WriteLine("Vous êtes tout juste majeur.");
            }
            else if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur.");
            }
            else if ((age >=12)&&(age < 18))
            {
                //condition ET
                Console.WriteLine("Vous êtes adolescent.");
            }
            else if ((age == 1)||(age == 2))
            {
                //condition OU
                Console.WriteLine("Vous êtes un bébé.");   
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes sénior.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous êtes majeur.");
            }
            else if (age < 10)
            {
                Console.WriteLine("Vous êtes un enfant.");
            }
            else
            {
                Console.WriteLine("Vous êtes mineur.");
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            // DEMANDER NOM
            string nom1 = DemanderNom(1);
            string nom2 = DemanderNom(2);


            // DEMANDER AGE
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // AFFICHER LES RESULTATS

            AfficherInfosPersonne(nom1, age1);
            AfficherInfosPersonne(nom2, age2);


            
            /*const int NB_PERSONNES = 3;
            //Permet de définir une variable (nombre de personnes) pour améliorer la lisibilité
            //On retrouve cette variable dans la boucle "for" afin qu'elle se mette à jour toute seule
            //"const" permet de dire que la variable est une constante : la valeur définie ne changera jamais, elle est fixe
            //Lors de la définition des constantes, on entre le nom de la variable en majuscule

            for (int i = 0; i < NB_PERSONNES; i++)
            {
                //Exemple de boucle "for"
                string nom = "Joueur " + (i + 1);
                int age = DemanderAge(nom);
                AfficherInfosPersonne(nom, age);
                Console.WriteLine();
                Console.WriteLine("---");*/

            }
        }
    }