using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne jp = new Personne("Jean-Pierre", "Polnareff", 89);
            Personne jb = new Personne("Jean-Baptiste", "Baptiste", 5);
            //Combien();
            jp.Afficher();
            jb.Afficher();
            Console.WriteLine("Le nombre de personne : " + Personne.Combien());
            Console.ReadLine();
        }
    }
}
