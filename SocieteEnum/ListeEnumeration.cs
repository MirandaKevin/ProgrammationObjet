﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SocieteAvecEnumerateur.Classes;

namespace SocieteAvecEnumerateur.Classes
{
    public class ListeEnumeration : IEnumerator<Liste>
    {
        private Liste _List;
        private int _indiceCourant;


        Liste IEnumerator<Liste>.Current => throw new NotImplementedException();
        object IEnumerator.Current => throw new NotImplementedException();

        public ListeEnumeration(Liste list)
        {
            _List = list;
        }

        public object Current()
        {
            return this._List[_indiceCourant].Objet;
        }


        public bool MoveNext()
        {
            this._indiceCourant++;
            if (this._indiceCourant > this._List.NbElements - 1)
                return false;
            return true;
        }

        public void Reset()
        {
            this._indiceCourant = 0;
        }

        public void Dispose()
        {
            _List = null;
            _indiceCourant = 0;
        }
    }
}