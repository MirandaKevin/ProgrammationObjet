using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecEnumerateur.Classes
{
    public class Employe : Personne
    {
        public int Salaire { get; set; }

        public Employe() : base()
        {
        }

        public Employe(int salaire, string nom, string prenom, int age) : base(nom, prenom, age)
        {
            this.Salaire = salaire;
        }


        public override string ToString()
        {
            return $"{this.Nom} {this.Prenom} {this.Age} {this.Salaire}";
        }

        public void Afficher(Employe employe)
        {
            Console.WriteLine($"Nom: {employe.Nom}");
            Console.WriteLine($"Prénom: {employe.Prenom}");
            Console.WriteLine($"Age: {employe.Age}");
            Console.WriteLine($"Age: {employe.Salaire}");
            Console.WriteLine("");
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.Nom}");
            Console.WriteLine($"Prénom: {this.Prenom}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Age: {this.Salaire}");
            Console.WriteLine("");
        }
    }
}