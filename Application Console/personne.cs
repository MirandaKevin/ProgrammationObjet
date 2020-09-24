using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application_Console
{
    public class Personne
    {
        private String Nom { get; set; }
        private String Prenom { get; set; }
        private int Age { get; set; }
        public static int Count { get; set; }

        public Personne(String nom, String prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Count++;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom + " Prenom : " + Prenom + " Age : " + Age);
        }

        public static int Combien()
        {
            return Count;

        }
    }
}  

