using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecEnumerateur.Classes
{
    public class Chef : Employe
    {
        public string Service { get; set; }

        public Chef() : base()
        {

        }

        public Chef(string service, int salaire, string nom, string prenom, int age) : base(salaire, nom, prenom, age)
        {
            this.Service = service;
        }

        public override string ToString()
        {
            return $"{this.Nom} {this.Prenom} {this.Age} {this.Salaire} {this.Service}";
        }

        public void Afficher(Chef chef)
        {
            Console.WriteLine($"Nom: {chef.Nom}");
            Console.WriteLine($"Prénom: {chef.Prenom}");
            Console.WriteLine($"Age: {chef.Age}");
            Console.WriteLine($"Age: {chef.Salaire}");
            Console.WriteLine($"Age: {chef.Service}");
            Console.WriteLine("");
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.Nom}");
            Console.WriteLine($"Prénom: {this.Prenom}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Age: {this.Salaire}");
            Console.WriteLine($"Age: {this.Service}");
            Console.WriteLine("");
        }
    }
}