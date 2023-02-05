//ETML
//Auteur      : Danilo Zivanovic
//Date        : 18.11.2022
//Descritpion : Ce porgramme demande une année entre 1900-2022 pour savoir si elle est Bissextile

namespace AnneeBissextiles_DaniloZivanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Annee Bissextiles";

            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║              Annee Bissextiles             ║");
            Console.WriteLine("╚════════════════════════════════════════════╝");

            int annee;

            // Demander à l'utilisateur de saisie une annee entre 1900-2022
            Console.Write("Donner une année entre 1900-2022 :");
                
            //Recuperer l'anne saisie par l'utilisateur
            string anneeSaisie = Console.ReadLine();

            //Convertir la variable en entier
            annee = Convert.ToInt32(anneeSaisie);

            //Prendre la valeur convertit en entier puis verifier si elle est divisble par 4 et 100 ou par 400
            bool divisblePar4 = annee % 4 == 0;

            bool divisblePar100 = annee % 100 == 0;

            bool divisblePar400 = annee % 400 == 0;

            bool estBisextile = (divisblePar4 && !divisblePar100) || divisblePar400;

            if (estBisextile)
            {
                Console.WriteLine("L'année est bisextile");
            }
            else { 
                Console.WriteLine("L'année n'est pas bisextile");

                = Console.ReadLine();
            }
        }
    }
}