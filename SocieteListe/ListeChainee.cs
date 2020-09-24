using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocieteListe
{
    
        public class Element
        {
            public Object valeur { get; set; }
            public Element suivant { get; set; }

            public  Element()
            {
                valeur = null;
                suivant = null;
            }

            public Element(Object uneValeur)
            {
                valeur = uneValeur;
                suivant = null;
            }

            public Element(Object uneValeur, Element unSuivant)
            {
                valeur = uneValeur;
                suivant = unSuivant;
            }

            public String ToString()
            {
            if (this.valeur == null) {
                return "''";
            }
            else
            {
                if (this.suivant != null)
                {

                    string strx = this.valeur.ToString() + " " + this.suivant.ToString();
                    return strx;
                }
                else
                {
                    string strx = this.valeur.ToString();
                    return strx;
                }
            }
        }

            

        public class Liste
        {
            public Element premier { get; set; }
            public int nbElement { get; set; }
            private Element[] arr = new Element[100];

            public Liste()
            {

            }

            public Liste(Element unPremier)
            {
                premier = unPremier;
            }

            public void completeTableau()
            {
                Element element = this.premier;
                if (element != null)
                {
                    int i = 0;
                    arr[i] = element;
                    while (element.suivant != null)
                    {
                        element = element.suivant;
                        i++;
                        arr[i] = element;
                    }
                }
            }

            public void ajouterDebut(object premier_objet)
            {
                Element aMettreDebut = new Element(premier_objet);
                // Inversion
                aMettreDebut.suivant = this.premier;
                this.premier = aMettreDebut;
                this.nbElement++;
                completeTableau();
            }

            public void getDernier()
            {
                // tant que element non null je vais au suivant, si je sors cest que cest le dernier
                //Console.Write()

            }

            public void ajouterFin(object dernier_objet)
            {
                Element aMettreFin = new Element(dernier_objet);
                if (this.premier == null)
                {
                    this.premier = aMettreFin;
                    this.nbElement++;
                    return;
                }
                // Element dernierElement = getDernier();
                //dernierElement.suivant = aMettreFin;
                //this.nbElement++;
                //completeTableau();


                //public String ToString()
                //{
                  //  if (this.premier == null)
                    //{
                      //  return "''";
                    //}
                    //else
                    //{
                      //  if (this.suivant != null)
                        //{

                          //  string strx = this.valeur.ToString() + " " + this.suivant.ToString();
                            //return strx;
                        //}
                        //else
                        //{
                          //  string strx = this.valeur.ToString();
                            //return strx;
                        //}
                    //}
                }

            public static void Main(string[] args)
            {
                Element a = new Element("1");
                Element b = new Element("2");
                Element c = new Element("3");
                //Element d = new Element("4");

                Liste maListe = new Liste();
                maListe.ajouterDebut(a);

                Console.Write(a.ToString());
                a.suivant = b;
                Console.Write(a.ToString());
                b.suivant = c;
                Console.Write(a.ToString());
                
                Console.ReadLine();
            }
        }
    }

       
        

    

}
