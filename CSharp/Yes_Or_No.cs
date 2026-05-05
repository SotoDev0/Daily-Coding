/*
Completa el método que toma un valor booleano y devuelve una cadena "Yes" para true, o
 una cadena "No" para false.
*/


using System;
using System.Linq;


Console.WriteLine(Kata.boolToWork(true));
Console.WriteLine(Kata.boolToWork(false));
Console.WriteLine(Kata.boolToWork(true));

public static class Kata
{
    public static string boolToWork(bool word)
    {
        return word ?  "Yes" : "No";
    }
}

