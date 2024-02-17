using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jul = 1;
            char s = 'a';
            double entrada;
            int conversion;

            double altura, ancho, perimeto, area;


            //Console.WriteLine("Escriba Altura");
            //altura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Escriba Ancho");

            //ancho = Convert.ToDouble(Console.ReadLine());

            //area = altura * ancho;

            //perimeto = 2 * (altura + ancho);

            //Console.WriteLine("El area es: " + area);
            //Console.WriteLine("El perimetro es: " + perimeto);

            //if (perimeto <= 6)
            //{

            //    Console.WriteLine("Perimetro pequeno");

            //}
            //else
            //{

            //    Console.WriteLine("Perimetro grande");
            //}






            List<string> lista = new List<string>();
            string nombre;
            Console.WriteLine("Llenar Lista");
            Console.WriteLine();
            Console.WriteLine("Escriba Nombre");
            nombre = Console.ReadLine();

            PracticaSwitch(nombre);
            int elementos = lista.Count;

            Console.Write("Los elementos de la lista son: ");

            for (int i = 0; i < elementos; i++)
            {

                Console.Write("'" + lista[i] + "'" + " ");
            }

            Console.WriteLine();

            Console.WriteLine("El numero de elementos de la lista es: {0}", elementos);
            //Tupla();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------------------------------------------------------------------------------------------------------------


            int[] matriz6 = new int[5] { 1, 2, 3, 4, 5 };

            
            int elementosMatriz;
            string nombrex;
            int contador = 0;
            Console.WriteLine("Llenar Matriz");
            Console.WriteLine("Inserte tamaño de la matriz");
            Console.WriteLine();
            elementosMatriz = Int32.Parse(Console.ReadLine());
            string[] matriz2 = new string[elementosMatriz];
            Console.WriteLine("Escriba Nombre");
            nombrex = Console.ReadLine();
            PracticaSwitch2(nombrex);

            Console.Write("Los elementos de la matriz son: ");
            

            

            for (int i = 0; i < elementosMatriz; i++)
            {
                if (matriz2[i]!= null)
                {

                    Console.Write("'" + matriz2[i] + "'"  + " ");


                }
            
            }

            Console.WriteLine();
            Console.WriteLine("El numero de elementos de la matriz es: {0}", elementosMatriz);
            Console.WriteLine();
            Console.WriteLine();
            Program.Tupla();





            void PracticaSwitch(string name)
            {


                string nombre2;
                nombre2 = name;

                switch (nombre2)
                {
                    case "Christian":

                        Console.WriteLine("Tu nombre es el correcto");
                        lista.Add(nombre2);

                        break;

                    case "Daniel":

                        Console.WriteLine("Ese es el nombre de tu hermano");
                        lista.Add(nombre2);
                        Console.WriteLine("Escriba el nombre correcto");
                        nombre2 = Console.ReadLine();
                        PracticaSwitch(nombre2);


                        break;

                    case "Jose":

                        Console.WriteLine("Ese nose quien sera");
                        lista.Add(nombre2);
                        Console.WriteLine("Escriba el nombre correcto");
                        nombre2 = Console.ReadLine();
                        PracticaSwitch(nombre2);

                        break;

                    default:

                        Console.WriteLine("Te falta carebro?");
                        lista.Add(nombre2);
                        Console.WriteLine("Escriba el nombre correcto");
                        nombre2 = Console.ReadLine();
                        PracticaSwitch(nombre2);

                        break;
                }

            }



            void PracticaSwitch2(string name)
            {


                string nombre2;
                nombre2 = name;

                switch (nombre2)
                {
                    case "Christian":

                        Console.WriteLine("Tu nombre es el correcto");
                        matriz2[contador] = nombre2;
                        contador += 1;                       
                        break;

                    case "Daniel":

                        if (contador < elementosMatriz)
                        {
                            Console.WriteLine("Ese es el nombre de tu hermano");
                            matriz2[contador] = nombre2;
                            contador += 1;
                            Console.WriteLine("Escriba el nombre correcto");
                            nombre2 = Console.ReadLine();
                            PracticaSwitch2(nombre2);

                        }
                        else
                        {
                            Console.WriteLine("Limite Alcanzado, Intente mas Tarde");


                        }

                        break;

                    case "Jose":

                        if (contador < elementosMatriz)
                        {

                            Console.WriteLine("Ese nose quien sera");
                        matriz2[contador] = nombre2;
                        contador += 1;
                        Console.WriteLine("Escriba el nombre correcto");
                        nombre2 = Console.ReadLine();
                        PracticaSwitch2(nombre2);

                        }
                        else
                        {
                            Console.WriteLine("Limite Alcanzado, Intente mas Tarde");


                        }

                        break;

                    default:

                        if (contador < elementosMatriz)
                        {

                            Console.WriteLine("Te falta carebro?");
                            matriz2[contador] = nombre2;
                            contador += 1;
                            Console.WriteLine("Escriba el nombre correcto");
                            nombre2 = Console.ReadLine();
                            PracticaSwitch2(nombre2);
                        }
                        else
                        {
                            Console.WriteLine("Limite Alcanzado, Intente mas Tarde");


                        }

                        break;
                }



            }

        }

            public static void Tupla()
            {

               (int Num1, int Num2) numeros = (2,3);

                Console.WriteLine("Los numeros son {0} y {1}", numeros.Num1, numeros.Num2); 
            }

            

    }
}
