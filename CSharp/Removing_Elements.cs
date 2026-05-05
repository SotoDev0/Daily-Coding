/*
Toma un arreglo y elimina cada segundo elemento del mismo. 
Conserva siempre el primer elemento y comienza a eliminar con el siguiente.

Ejemplo:
["Keep", "Remove", "Keep", "Remove", "Keep", ...]-->["Keep", "Keep", "Keep", ...]

Ninguno de los arrays estará vacío, ¡así que no tienes que preocuparte por eso!
*/
using System.Linq;
using System;

object[] myList = { "Keep", "Remove", "Keep", "Remove" };
var resultado = Kata.Removing(myList);
Console.WriteLine(string.Join(" ",resultado));

public class Kata
{
    public static object[] Removing(object[] arr)
    {
        return arr.Where((e,i) => i%2 == 0).ToArray();
    }
}


