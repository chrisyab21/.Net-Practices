using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class auto: vehiculo
    {
        private string marca;

        private string traccion;

        //private int cilindrada;

        



        public auto(int velA, int capA, string marcaX, string traccionX, int cilindrada):base (velA, capA, cilindrada)
        {

            this.marca = marcaX;
            this.traccion = traccionX;

        }


        //public void combustible()
        //{

        //    Console.WriteLine("Uso gasolina de auto");
        //}


        //public int CILINDRADA { 
            
        //    get
        //    {

        //        return this.cilindrada;
        //    }


        //    set
        //    {

        //        this.cilindrada = value;  
        //    } 
        
        //}



        //public int AutomentarCILINDRADA
        //{

        //    get
        //    {

        //        return this.cilindrada;
        //    }


        //    set
        //    {

        //        this.cilindrada = this.cilindrada + value;
        //    }

        //}



        public override void Moverse()
        {

            Console.WriteLine("Estoy rodando");
        }


        public new void Moverse2()
        {

            Console.WriteLine("Estoy rodando con new");
        }

    }
}
