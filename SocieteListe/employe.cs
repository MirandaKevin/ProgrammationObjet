using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SocieteListe
{
    class Employe : Personne
    {
    
    public Double Salaire { get; set; }

        public Employe() : base(){
        }

        public Employe(int salaire, String nom, String prenom, int age) :base (nom,prenom,age)
    {
        Salaire = salaire;
    }


  

    public void Afficher()
    {
        Console.WriteLine("Nom : " + this.Nom + " Prenom : " + this.Prenom + " Age : " + this.Age + " Salaire : " +this.Salaire);
    }

    
}
}
