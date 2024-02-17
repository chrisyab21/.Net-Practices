// See https://aka.ms/new-console-template for more information
using Interfaces;
using System.Collections;
using System.Linq.Expressions;


//---------------------------------------------------------------Programa1-------------------------------------------------------------------------------------

//auto auto = new auto(80, 4,"Audi","4x4");
//moto Moto1 = new moto(120, 2, "Deportiva");

//auto.MostrarVelocidad();
//auto.MostrarCapacidad();

//Moto1.queSoy();
//Moto1.GetTipo();

////((IVehiculoaMotor)Moto1).CILINDRADA = 7;

//Moto1.CILINDRADA = 500;
//auto.CILINDRADA = 800;

//auto.AutomentarCILINDRADA = 1000;

//Console.WriteLine("" + Moto1.CILINDRADA);
//Console.WriteLine("" + auto.CILINDRADA);

//auto.combustible();


//Moto1.MostrarVelocidad();


//---------------------------------------------------------------Creacion y uso de listas y array-------------------------------------------------------------------------------------


List<int> numeros = new List<int>()
        {
            1,
            2,
            3,
            4,
            5,

        };


List<int> numeros2 = new List<int>(4);

numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);

//Creacion de un arreglo o tambien llamado vector de 12 elementos utilizando la clase Array.(Se parece mucho a la creacion de objetos) 

Array array1 = new int[5];

ArrayList arrayList = new ArrayList();  

int tamaño = array1.Length;

array1.SetValue(45,0);

Console.WriteLine("El tamaño del array es: " + tamaño);
Console.WriteLine();
Console.WriteLine("El valor del array en el indice 0 es: " + array1.GetValue(0));
Console.WriteLine();
Console.WriteLine("El valor del array en el indice 1 es: " + array1.GetValue(1));
Console.WriteLine();

//Creacion de un arreglo o tambien llamado vector de 10 elementos de forma tradicional.(Se parece mucho a la creacion de objetos) 

int[] numerosX = new int[10] {1,2,3,4,54,5,6,7,8,9};

int[] numeros3 = new int[5];

numeros3[0] = 67;



foreach (int item in array1)
{

    Console.WriteLine("Viva Messi");
}


Console.WriteLine("El valor del vector en el indice 0 es: " + numeros3[0]);
Console.WriteLine();



//---------------------------------------------------------------Programa2-------------------------------------------------------------------------------------



vehiculo auto = new auto(80, 4, "Audi", "4x4", 5000);
vehiculo avion = new avion("Latam", "Comercial", 700, 120, 12000);
vehiculo barco = new barco("Royal Caribean", "Crucero", 80, 3000, 40000);

auto auto2 = new auto(80, 4, "Audi", "4x4", 6000);

vehiculo[] vehiculos = new vehiculo[3];
vehiculos[0] = auto;
vehiculos[1] = avion;
vehiculos[2] = barco;





    for (int i = 0; i < 3; i++)
    {
    vehiculos[i].Moverse();
   ((IVehiculoaMotor)vehiculos[i]).Saludar();

    int cili = vehiculos[i].CILINDRADA;
    Console.WriteLine("La cilindrada es: " + cili);

}

    ((IVehiculoaMotor)auto2).combustible();


 //  ((IVehiculoaMotor)auto).Saludar();
  


//for (int i = 0; i < 3; i++)
//{
//    vehiculos[i].Moverse2();

//}