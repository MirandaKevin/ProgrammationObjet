using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocieteListe
{
    class Directeur : Chef
    {
        public String Societe { get; set; }

        public Directeur() : base()
        {

        }

        public Directeur(String societe, String service, int salaire, String nom, String prenom, int age) : base(service,salaire,nom,prenom,age)
        {
            Societe = societe;
        }


        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom + " Prenom : " + Prenom + " Age : " + Age + " Salaire : " + Salaire +" Service : " +Service+" Societe : " +Societe) ;
        }

        


    }
}
