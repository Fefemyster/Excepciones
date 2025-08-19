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

                int sumaNotas = 0;   // para acumular las notas válidas
                int cantidadNotasValidas = 0; // para contar solo las notas correctas

                for (int i = 0; i < cantidadNotas; i++)
                {
                    try
                    {
                        Console.WriteLine("Ingrese sus notas");
                        int notas = Convert.ToInt32(Console.ReadLine());
                        if (notas < 0 || notas > 100)
                        {
                            throw new Exception("Las notas deben de ser entre 0 y 100");
                        }

                        sumaNotas += notas; // esto es igual que esto: sumaNotas = sumaNotas + notas;
                        cantidadNotasValidas++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Valor inválido, ingrese un número.");
                        i--; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Advertencia {ex.Message}");
                        i--;
                    }

                }//Fin de for

                if (cantidadNotasValidas > 0)
                {
                    double promedio = (double)sumaNotas / cantidadNotasValidas;
                    Console.WriteLine($"El promedio de sus notas es: {promedio}");
                }
                else
                {
                    Console.WriteLine("No se ingresaron notas válidas.");
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





