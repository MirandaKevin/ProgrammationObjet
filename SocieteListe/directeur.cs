using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecListe.Classes
{
    public class Directeur : Chef
    {
        public string Societe { get; set; }

        public Directeur() : base()
        {

        }

        public Directeur(string societe, string service, int salaire, string nom, string prenom, int age) : base(service, salaire, nom, prenom, age)
        {
            this.Societe = societe;
        }

        public override string ToString()
        {
            return $"{this.Nom} {this.Prenom} {this.Age} {this.Salaire} {this.Service} {this.Societe}";
        }

        public void Afficher(Directeur directeur)
        {
            Console.WriteLine($"Nom: {directeur.Nom}");
            Console.WriteLine($"Prénom: {directeur.Prenom}");
            Console.WriteLine($"Age: {directeur.Age}");
            Console.WriteLine($"Age: {directeur.Salaire}");
            Console.WriteLine($"Age: {directeur.Service}");
            Console.WriteLine($"Age: {directeur.Societe}");
            Console.WriteLine("");
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {this.Nom}");
            Console.WriteLine($"Prénom: {this.Prenom}");
            Console.WriteLine($"Age: {this.Age}");
            Console.WriteLine($"Age: {this.Salaire}");
            Console.WriteLine($"Age: {this.Service}");
            Console.WriteLine($"Age: {this.Societe}");
            Console.WriteLine("");
        }
    }
}