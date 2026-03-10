// 1.Diccionario con tres elementos que representen un país y su capital.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> paises = new Dictionary<string, string>();
        paises.Add("República Dominicana", "Santo Domingo");
        paises.Add("España", "Madrid");
        paises.Add("México", "Ciudad de Mexico");
        Console.WriteLine("--- Estas son las listas de mis Países y Capitales ---");
        foreach (var item in paises)
        {
            Console.WriteLine("País: " + item.Key + " | Capital: " + item.Value);
        }
        Console.WriteLine("\nJades, presiona Enter para finalizar...");
        Console.ReadLine();
    }
}