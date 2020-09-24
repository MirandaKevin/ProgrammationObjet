using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SociéteTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            
          




            var arrayPers = new List<Personne>();

            Employe emp1 = new Employe(1500, "Employe", "Un", 55);
            Chef chef1 = new Chef("SERVICE RH", 2500, "Chef", "UN", 26);

            arrayPers.Add(emp1);
            arrayPers.Add(new Employe(1500, "Employe", "DEUX", 40));
            arrayPers.Add(new Employe(1500, "Employe", "TROIS", 42));
            arrayPers.Add(new Employe(1500, "Employe", "QUATRE", 38));
            arrayPers.Add(new Employe(1500, "Employe", "CINQ", 49));
            arrayPers.Add(chef1);
            arrayPers.Add(new Chef("SERVICE IT",2500, "Chef", "DEUX", 26));
            arrayPers.Add(new Directeur("MAGASIN LECLERC","SERVICE DIRECTION",3500, "Directeur", "UN", 26));


            //BOUCLE FOR

            //MODIFICATION D'un Employe

            //emp1.Age = emp1.Age + 1;
            //chef1.Salaire = chef1.Salaire * 2;
            //chef1.Service = "SERVICE MARKETING";

            // BOUCLE FOR EACH
            arrayPers.ForEach(pers =>
            {
                pers.Afficher();
            });











            Console.ReadLine();
        }
    }
}
