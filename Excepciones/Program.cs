using System;


bool detener = false;

do
{
    Console.WriteLine("Presione 0 para salir");
    Console.WriteLine("Ingrese la cantidad de notas a evaluar");

    try
    {
        int cantidadNotas = Convert.ToInt32(Console.ReadLine());
        if (cantidadNotas == 0)
        {
            detener = true;
        }
    }
    catch (FormatException e) { Console.WriteLine("Valor invalido"); }
    

}
while (!detener);






Console.WriteLine("Ingrese sus notas");
int notas = Convert.ToInt32(Console.ReadLine());

