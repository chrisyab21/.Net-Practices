
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIEnumerables
{
    internal class Contenedora : IEnumerable
    {

        private int[] valores = new int[10];

        public Contenedora()
        {
            for (int i = 0; i < valores.Length; i++)
            {

                valores[i] = i * i;

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            EnumeradorDeContenedora Enumerator1 = new EnumeradorDeContenedora(valores);

            return Enumerator1;

        }
    }
}
