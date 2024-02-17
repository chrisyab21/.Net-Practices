// See https://aka.ms/new-console-template for more information
using Genericos;
using System.Threading.Tasks.Dataflow;



Console.WriteLine("Hello, World!");


        int ValorElemento1;

        GuardaObjetos<int> objeto1 = new GuardaObjetos<int>(3);

        objeto1.AgregarElemento(5);
        objeto1.AgregarElemento(2);
        objeto1.AgregarElemento(3);


        ValorElemento1 = objeto1.ObtenerElemento(0);

        Console.WriteLine(ValorElemento1);




//---------------------------------------------------------Programa2-----------------------------------------------------------------------------------------

        Alumno ValorElemento2;
        GuardaObjetos<Alumno> objeto2 = new GuardaObjetos<Alumno>(3);

        Alumno alumno1 = new Alumno("Zoey",8);

        Alumno alumno2 = new Alumno("Marco",6);
        Alumno alumno3 = new Alumno("Dai",9);

        objeto2.AgregarElemento(alumno1);
        objeto2.AgregarElemento(alumno2);
        objeto2.AgregarElemento(alumno3);

        ValorElemento2 = objeto2.ObtenerElemento(2);

        Console.WriteLine(ValorElemento2.NOMBRE + " " + ValorElemento2.CALIFICACION);





//Funcion que recibe algo de tipo T y lo asigna a la una variable de tipo T (generica)

    void AsignarElemento<T> (T elemento)
    {

    T i = elemento;

    }



//Clase generica que recibe un dato tipo T

public class GuardaObjetos<T>
{

    int i=0;
    private T[] matrizElementos;

    
    public GuardaObjetos(int tamaño)
    {
        this.matrizElementos = new T[tamaño];
    }   


    public void AgregarElemento(T elemento)
    {

        matrizElementos[i] = elemento;
        i++;
    }


    public T ObtenerElemento(int indice)
    {
        return matrizElementos[indice];


    }







}