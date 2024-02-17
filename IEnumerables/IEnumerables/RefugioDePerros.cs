using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
    internal class RefugioDePerros : IEnumerable<Perro>
    {
        List<Perro> perros;



        public RefugioDePerros()
        {

            perros = new List<Perro>() {

                new Perro("Dana", true),
            };

            Perro perro2 = new Perro("Bruno", false);
            Perro perro3 = new Perro("Rufy", false);

            perros.Add(perro2); ;

            perros.Add(perro3);

        }




        public void recorrer()
        {

            foreach (Perro perro in perros)
            {

                Console.WriteLine("Mi nombre es: " + perro.name);

            }

        }


        public IEnumerator<Perro> GetEnumerator()
        {


            return perros.GetEnumerator();
        }




        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}

