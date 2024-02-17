using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class avion: vehiculo
    {

        private string aerolinea;
        private string clase;



        public avion(string aerolinea, string clase, int velocidad, int capacidad, int cilindrada) : base(velocidad, capacidad, cilindrada)
        
        {

            this.aerolinea = aerolinea;

            this.clase = clase;

        }




        public string AEROLINEA {

            get{ 
               
                return aerolinea; 
            }

            set{ 
                
                aerolinea = value; 
            }
        
        
        }


        public override void Moverse()
        {

            Console.WriteLine("Estoy volando");

        }

        public new void Moverse2()
        {

            Console.WriteLine("Estoy volando con new");

        }


        //public int CILINDRADA {

        //    get{
                
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
