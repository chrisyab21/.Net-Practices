using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInterfazBasica
{
    internal class Auto: IAutomovil
    {
        public double costo;
        public double tenencia;
        public string modelo;


        public Auto(string pModelo, double pCosto)
        {

            costo = pCosto;
            modelo = pModelo;

        }


        public double CalculaTenencia(double impuesto)
        {
            
            tenencia =  (costo * impuesto) / 100;

            return tenencia;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu automovill {0}", modelo);
            Console.WriteLine("El costo es: {0} con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("El Total: {0}", costo + tenencia);
            Console.WriteLine("----------------");
        }
    }
}
