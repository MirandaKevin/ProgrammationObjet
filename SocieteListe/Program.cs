using SocieteAvecListe.Classes;
using System;
using System.Collections.Generic;

namespace SocieteAvecListe
{
    class Program
    {
        static void Main(string[] args)
        {
            Liste arrayPers = new Liste();

            Employe e1 = new Employe(1500, "Josef", "Triangle", 25);
            Employe e2 = new Employe(1500, "Blandine", "Trompette", 30);
            Employe e3 = new Employe(1500, "Fany", "Piano", 35);
            Employe e4 = new Employe(1500, "Dany", "Synthé", 40);
            Employe e5 = new Employe(1500, "Mara", "Maracasse", 45);
            Chef c1 = new Chef("DRH", 3000, "Gerard", "Contrebasse", 26);
            Chef c2 = new Chef("DSI", 3000, "Jean-Pierre", "Clarinette", 58);
            Directeur d = new Directeur("La Compagnie Musical", "Directeur", 5000, "Thierry", "Guitard", 24);

            arrayPers.InsererDebut(e1);
            arrayPers.InsererDebut(e2);
            arrayPers.InsererDebut(e3);
            arrayPers.InsererDebut(e4);
            arrayPers.InsererDebut(e5);
            arrayPers.InsererDebut(c1);
            arrayPers.InsererDebut(c2);
            arrayPers.InsererDebut(d);

            Console.WriteLine(" ----- LISTE ACTUEL DES EMPLOYE -----");
            for (int i = 0; i < arrayPers.NbElements; i++)
            {
                Console.WriteLine("-> "+arrayPers[i].Objet.ToString());
            }
            Console.WriteLine("  ");
            Console.WriteLine($"----- Nombre d'employes : {arrayPers.NbElements} -----");
            //arrayPers.Lister();

            Console.WriteLine("----- Vidage de la liste -----");
            arrayPers.Vider();

            Console.WriteLine($"----- Nombre d'employes : {arrayPers.NbElements} -----");
            arrayPers.Lister();

            Console.WriteLine("----- Insertion à la fin de la liste -----");
            arrayPers.InsererFin(e1);
            arrayPers.InsererFin(e2);
            arrayPers.InsererFin(e3);
            arrayPers.InsererFin(e4);
            arrayPers.InsererFin(e5);
            arrayPers.InsererFin(c1);
            arrayPers.InsererFin(c2);
            arrayPers.InsererFin(d);

            Console.WriteLine($"----- Nombre d'employes : {arrayPers.NbElements} -----");
            Console.WriteLine($"----- INDEXEUR : {arrayPers.NbElements} -----");
            Console.WriteLine("  ");
            for (int i = 0; i < arrayPers.NbElements; i++)
            {
                Console.WriteLine("-> "+arrayPers[i].Objet.ToString());
            }
            Console.ReadLine();
        }
    }
}
