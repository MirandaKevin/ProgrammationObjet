using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociéteTableau
{
    class Chef : Employe
    {
        public String Service { get; set; }

        public Chef(): base()
        {

        }
        public Chef(String service, int salaire, String nom, String prenom, int age) : base(salaire,nom,prenom,age)
        {
             Service = service;
        }

        

        

        public void Afficher()
        {
            Console.WriteLine("Nom : " + Nom + " Prenom : " + Prenom + " Age : " + Age + " Salaire : " + Salaire + " Service : " +Service);
        }

        
    }
}
