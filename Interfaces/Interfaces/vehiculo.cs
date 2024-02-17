using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class vehiculo: IVehiculoaMotor
    {

        private int velocidad;
        private int capacidad;

        private int cilindrada;

        public vehiculo(int vel, int cap, int cilindrada)
        {
            this.velocidad = vel;
            this.capacidad = cap;
            this.cilindrada = cilindrada;

        }

        //public string cilindrada { 
        //    get => throw new NotImplementedException(); 
        //    set => throw new NotImplementedException(); 
        //}


        //public void combustible()
        //{
        //    Console.WriteLine("El tipo de combustible del vehiculo es: gasolina");
        //}


        public void MostrarCapacidad()
        {

            Console.WriteLine("Mi capacidad es: " + capacidad); ;
        }

        public void MostrarVelocidad()
        {

            Console.WriteLine("Mi velocidad es: " + velocidad); 
        }

        public virtual void Moverse()
        {
            Console.WriteLine("Me muevo de alguna forma");

        }


        public void Moverse2()
        {
            Console.WriteLine("Me muevo de alguna forma con new");

        }



        public int CILINDRADA
        {

            get
            {

                return cilindrada;

            }
            set
            {
                this.cilindrada = value;

            }


        }








    }
}
