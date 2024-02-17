using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class barco: vehiculo
    {
        private string compañia;
        private string tipo;



        public barco(string compañia, string tipo, int velocidad, int capacidad, int cilindrada) : base(velocidad, capacidad, cilindrada)

        {

            this.compañia = compañia ;

            this.tipo = tipo;

        }




        public string COMPAÑIA
        {

            get
            {

                return compañia;
            }

            set
            {

                compañia = value;
            }


        }


        public override void Moverse()
        {

            Console.WriteLine("Estoy navegando");

        }


        public new void Moverse2()
        {

            Console.WriteLine("Estoy navegando con new");

        }


        //public int CILINDRADA
        //{

        //    get
        //    {

        //        return CILINDRADA;

        //    }
        //    set
        //    {

        //        this.CILINDRADA = value;
        //    }


        //}


        //public void combustible()
        //{



        //}



    }
}
