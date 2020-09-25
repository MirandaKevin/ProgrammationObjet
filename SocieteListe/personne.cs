using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecListe.Classes
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Personne() { }

        public Personne(string nom, string prenom, int age)
        {
            this.Prenom = prenom;
            this.Nom = nom;
            this.Age = age;
        }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age;
        }

        public void Afficher(Personne personne1)
        {
            Console.WriteLine($"Nom: {personne1.Nom}");
            Console.WriteLine($"Prénom: {personne1.Prenom}");
            Console.WriteLine($"Age: {personne1.Age}");
            Console.WriteLine("");
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.Nom}");
            Console.WriteLine($"Prénom: {this.Prenom}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine("");
        }
    }
}