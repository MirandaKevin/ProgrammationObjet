using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocieteListe
{
    class Personne
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int Age { get; set; }

        public Personne() { }

        public Personne(String nom, String prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        public Personne(String nom) {
            Nom = nom;
            Prenom = "vide";
            Age = 0;
        }

        public String ToString(int chiffre)
        {
            int x = chiffre;
            string strx = x.ToString();
            return strx;
        }
        public String ToString(double chiffre)
        {
            double x = chiffre;
            string strx = x.ToString();
            return strx;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom + " Prenom : " + Prenom + " Age : " + Age);
        }

        public void Afficher(String nom)
        {
            Console.WriteLine(">>>>Bonjour ci dessous les information de " + nom + "<<<<");
            Console.WriteLine("Nom : " + Nom + " Prenom : " + Prenom + " Age : " + Age);
        }

        //public void ++(String nom)
        //{
          //  Personne personne = new Personne(nom);
            //personne.Age = personne.Age + 1;
        //}

    }
}
