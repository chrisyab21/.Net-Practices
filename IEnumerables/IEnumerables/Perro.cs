using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    internal class Perro
    {

        public string? name;
        public bool Travieso;





        public Perro(string nombre, bool comportamiento)
        {

            this.name = nombre;

            this.Travieso = comportamiento; 


        }



        public void Apapachar(int numeroDeCaricias)
        {


            Console.WriteLine("El perro {0} hace woof {1} dos veces", name, numeroDeCaricias);
        }


    }
}
