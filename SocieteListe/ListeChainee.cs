using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteAvecListe.Classes
{
    public class Element
    {
        private object _Object;
        private Element _Suivant;

        public Element(object _object)
        {
            this._Object = _object;
        }

        public object Objet { get => _Object; set => _Object = value; }
        public Element Suivant { get => _Suivant; set => _Suivant = value; }
    }

    public class Liste
    {
        private Element _Debut;
        private int _NbElements;

        private Element[] arr = new Element[100];

        public void FillArray()
        {
            Element element = this._Debut;
            if (element != null)
            {
                int i = 0;
                arr[i] = element;
                while (element.Suivant != null)
                {
                    element = element.Suivant;
                    i++;
                    arr[i] = element;
                }
            }
        }

        public Element this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public int NbElements { get => _NbElements; }

        public Liste()
        {
            _Debut = null;
            _NbElements = 0;
        }
        public void InsererDebut(object premier_objet)
        {
            Element newDebut = new Element(premier_objet);
            newDebut.Suivant = this._Debut;
            this._Debut = newDebut;
            this._NbElements++;
            FillArray();
        }

        public void InsererFin(object dernier_objet)
        {
            Element newFin = new Element(dernier_objet);
            if (this._Debut == null)
            {
                this._Debut = newFin;
                this._NbElements++;
                return;
            }
            Element dernierElement = RecupereDernierElement();
            dernierElement.Suivant = newFin;
            this._NbElements++;
            FillArray();
        }

        public Element RecupereDernierElement()
        {
            Element element = this._Debut;
            while (element.Suivant != null)
            {
                element = element.Suivant;
            }
            return element;
        }

        public void Lister()
        {
            Element element = this._Debut;
            if (element != null)
            {
                string cumul = element.Objet.ToString();
                while (element.Suivant != null)
                {
                    element = element.Suivant;
                    cumul += "," + element.Objet.ToString();
                }
                Console.WriteLine(cumul);
            }
            else
            {
                Console.WriteLine("----- La liste est vide -----");
            }
        }

        public void Vider()
        {
            this._Debut = null;
            this._NbElements = 0;
            FillArray();
        }

    }
}