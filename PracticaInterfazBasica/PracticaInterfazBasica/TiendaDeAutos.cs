using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfazBasica
{
    internal class TiendaDeAutos
    {

        private Auto[] AutosDiponibles;


        public TiendaDeAutos()
        {
            AutosDiponibles = new Auto[4]
            {
              AutosDiponibles[0] =  new Auto("Nissan",12000),
              AutosDiponibles[1] =  new Auto("Toyota",15000),
              AutosDiponibles[2] =  new Auto("Bmv",30000),
              AutosDiponibles[3] =  new Auto("Lexus",90000),


            };



        }
    }
}
