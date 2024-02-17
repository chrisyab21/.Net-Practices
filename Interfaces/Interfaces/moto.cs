using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class moto: vehiculo, IVehiculoaMotor


    {

        public string Tipo;

        private int cilindrada;

        //string IVehiculoaMotor.CILINDRADA { 
            
        //    get { return this.cilindrada; } 
        //    set { } 
        
        //}


        public moto(int vel, int cap, string tipo, int cilindrada):base(vel, cap, cilindrada)
        {

            this.Tipo = tipo;

        }


        public void queSoy()
        {

            Console.WriteLine("Soy una moto");

        }

        public void GetTipo()
        {

            Console.WriteLine("Soy una moto de tipo: " + Tipo);

        }

        public void combustible()
        {
            Console.WriteLine("Uso gasolina de moto");

        }

        public int CILINDRADA
        {

            get
            {

                return this.cilindrada;
            }

            set

            {
                if (value == 5000)
                {
                    Console.WriteLine("Soy una moto de motor grande");
                    this.cilindrada = value;

                }
                else
                {
                    Console.WriteLine("Soy una moto de motor normal");

                    this.cilindrada = value;


                }


            }
        }



    }
}
