// 6. Diccionario de 5 elementos y muestra solo sus valores.

Dictionary<string, int> inventario = new Dictionary<string, int>();
inventario.Add("Manzanas", 50);
inventario.Add("Peras", 30);
inventario.Add("Uvas", 25);
inventario.Add("Mangos", 40);
inventario.Add("Piñas", 15);

Console.WriteLine("--- Extracción de Datos Numéricos ---");
Console.WriteLine("Buscando solo las cantidades en inventario...");
Console.WriteLine("\nLISTA DE VALORES (CANTIDADES):");
Console.WriteLine("------------------------------");

foreach (int cantidad in inventario.Values)
{
    Console.WriteLine("Cantidad: " + cantidad);
}

Console.WriteLine("\nPresiona Enter para finalizar...");
Console.ReadLine();