
/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */

namespace CSharp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string texto = "hola mucho gusto hola gusto gusto Hola";
            string texto_limpio = "";
            
            
            /*Almacena en una variable solo las letras, numeros o espacios*/
            foreach (char c in texto)
            {
                if (char.IsLetterOrDigit(c) || c == ' ')
                {
                    texto_limpio +=char.ToLower(c);
                }
            }

            
            string[] Palabras = texto_limpio.Split(" ");
            Dictionary<string,int> contador = new Dictionary<string, int>();


            foreach (string p in Palabras)
            {
                if (string.IsNullOrWhiteSpace(p))
                {
                    continue;
                }

                if (contador.ContainsKey(p))
                {
                    contador[p] +=1; 
                }
                else
                {
                    contador[p] = 1;
                }
            }

            foreach (var elemento in contador)
            {
                Console.WriteLine($"Palabra: {elemento.Key} Cantidad: {elemento.Value}");
            }

        }
    }
}