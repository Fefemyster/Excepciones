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
        else if (cantidadNotas < 0)
        {
            throw new Exception("El número de notas debe ser mayor que cero.");
        }
        else {
            {
                Console.WriteLine($"Vas a evaluar {cantidadNotas} notas.");
                for (int i = 0; i < cantidadNotas; i++)
                {
                    try
                    {
                        Console.WriteLine("Ingrese sus notas");
                        int notas = Convert.ToInt32(Console.ReadLine());
                        if (notas < 0 || notas >100)
                        {
                            throw new Exception("Las notas deben de ser entre 0 y 100");
                        }
                        
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Valor invalido, ingrese un numero");
                    }

                }

            }
        }
    }
    catch (FormatException e) {
        Console.WriteLine("Valor invalido, ingrese un numero"); 
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Advertencia: {ex.Message}");
    }



}
while (!detener);





