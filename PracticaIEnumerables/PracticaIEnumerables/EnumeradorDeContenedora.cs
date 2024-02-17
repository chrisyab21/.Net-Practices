using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIEnumerables
{
    internal class EnumeradorDeContenedora:IEnumerator
    {

        private int indice = -1;

        private int[] estructura;

        public EnumeradorDeContenedora(int[] pEstructura)
        {
            this.estructura = pEstructura;  

        }

        public object Current
        {
            get
            {
                return estructura[indice];
            }
        }

        public bool MoveNext()
        {
            indice=  indice+1;
            if (indice < estructura.Length)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        public void Reset()
        {
            indice = -1;
        }
    }
}
