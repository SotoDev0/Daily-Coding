/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
*/

namespace Convertir_Decimal
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Introduce un numero decimal: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            string binario = "";

            // En caso que la variable "numeroDecimal" sea 0
            if (numeroDecimal == 0)
            {
                binario = "0";
            }
            else
            {
                while(numeroDecimal > 0)
                {   
                    // Almacenar el residuo
                    int residuo = numeroDecimal % 2;

                    //Concatenar el residuo al inicio del string
                    binario = residuo + binario;

                    //Actualizar la variable "numeroDecimal"
                    numeroDecimal  /= 2;
                }
            }

            Console.WriteLine($"El resultado binario es : {binario}");
        }
    }


}
