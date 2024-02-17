using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyecciondeDependencia
{
    internal class Cantinero
    {

        IBebida Bebida;

        public Cantinero(IBebida pBebida)
        {
            this.Bebida = pBebida;


        }

        public void PrepararBebida()
        {
            this.Bebida.Preparar();
            

        }


    }
}
