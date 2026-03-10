//5. Diccionario de 5 elementos y muestra solo sus claves.

Dictionary<string, int> inventario = new Dictionary<string, int>();
inventario.Add("Manzanas", 50);
inventario.Add("Peras", 30);
inventario.Add("Uvas", 25);
inventario.Add("Mangos", 40);
inventario.Add("Piñas", 15);

Console.WriteLine("--- Diccionario Completo Creado ---");
Console.WriteLine("Buscando solo las etiquetas de los productos...");
Console.WriteLine("\nLISTA DE CLAVES (PRODUCTOS):");
Console.WriteLine("----------------------------");
foreach (string producto in inventario.Keys)
{
    Console.WriteLine("-> " + producto);
}

Console.WriteLine("\nJades, presiona Enter para finalizar...");
Console.ReadLine();