using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehiculoaMotor
    {

        public int CILINDRADA { get; set; }



        public void combustible()
        {

            Console.WriteLine("Heredo combustible desde la interfaz");

        }


        public void Saludar()
        {

            Console.WriteLine("Te saludo desde la interfaz");
        }

    }
}
