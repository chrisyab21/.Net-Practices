using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeTask
{
    internal class Brasil
    {

        Task<int> Tarea1 = new Task<int>(() => {

            Console.WriteLine("Todo va bien con Task");
            return 29;           
            }      
        );


        Task Tarea3 = new Task(() => Console.WriteLine("Todo va bien con Task"));


        Task<int> Tarea2 = Task.Run(() => 90);


        public Task<int> Suma()
        {

            return Task.Run(() => { 

            Console.WriteLine("Hola perro");
            return 88;

            });  

                
        }


        public async Task<int> Suma2()
        {
            Tarea1.Start();
            return await Tarea1;

        }






        public async void SumaSinTask()
        {

            await Task.Run(() => { });

        }


        public async Task<string> Suma3()
        {

            return await Task.Run(() => "Hola");   

        }

        public async Task Suma4()
        {

           await Task.Run(() => "Hola");

           await Task.Run(() => 40);

        }



    }
    
}
