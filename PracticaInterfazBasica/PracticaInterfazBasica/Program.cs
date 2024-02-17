// See https://aka.ms/new-console-template for more information

using PracticaInterfazBasica;

Auto Auto1 = new Auto(pModelo:"Toyota Corolla", pCosto:100){};


Console.WriteLine("Coloque su impuesto aqui");

string impuesto = Console.ReadLine();

double tenencia = Auto1.CalculaTenencia(Int32.Parse(impuesto));


Auto1.MuestraInformacion();