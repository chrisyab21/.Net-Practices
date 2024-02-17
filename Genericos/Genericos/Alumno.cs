using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Alumno
    {
        private double calificacion;
        private string nombre;


        public Alumno(string nombre,double nota)
        {

            this.nombre = nombre;
            this.calificacion = nota;     

        }

        public double CALIFICACION
        {

            get
            {

                return this.calificacion;
            }

        }

        public string NOMBRE
        {


            get
            {
                return this.nombre;

            }

        }


    }
}
