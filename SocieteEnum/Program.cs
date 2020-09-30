using SocieteAvecEnumerateur.Classes;
using System;

namespace SocieteAvecEnumerateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste arrayPers = new Liste();

            Employe employe1 = new Employe(2500, "Dubosc", "Franck", 55);
            Employe employe2 = new Employe(3500, "Youn", "Michael", 40);
            Employe employe3 = new Employe(4500, "Boon", "Dany", 42);
            Employe employe4 = new Employe(2300, "Foresti", "Florence", 38);
            Employe employe5 = new Employe(2300, "Semoune", "Elie", 49);
            Chef chef1 = new Chef("Humoriste", 5000, "Gardin", "Blanche", 26);
            Chef chef2 = new Chef("Humoriste", 3000, "Robin", "Murielle", 58);
            Directeur directeur = new Directeur("Head&Shoulders", "Direction", 2700, "Adams", "Kevin", 24);

            arrayPers.InsererDebut(employe1);
            arrayPers.InsererDebut(employe2);
            arrayPers.InsererDebut(employe3);
            arrayPers.InsererDebut(employe4);
            arrayPers.InsererDebut(employe5);
            arrayPers.InsererDebut(chef1);
            arrayPers.InsererDebut(chef2);
            arrayPers.InsererDebut(directeur);

            Console.WriteLine($"Nb éléments : {arrayPers.NbElements}");
            Console.WriteLine("Indexeur");
            for (int i = 0; i < arrayPers.NbElements; i++)
            {
                Console.WriteLine(arrayPers[i].Objet.ToString());
            }

            ListeEnumeration enumPers = new ListeEnumeration(arrayPers);
            Console.WriteLine($"Nb éléments : {arrayPers.NbElements}");
            Console.WriteLine("Enumerateur");
            do
            {
                Console.WriteLine(enumPers.Current().ToString());
            }
            while (enumPers.MoveNext());
            Console.ReadLine();
        }
    }
}