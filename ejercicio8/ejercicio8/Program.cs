// 8. Diccionario y usa un bucle para imprimir cada clave con su valor.

Dictionary<string, string> ciudades = new Dictionary<string, string>();
ciudades.Add("SDQ", "Santo Domingo");
ciudades.Add("STI", "Santiago");
ciudades.Add("PUJ", "Punta Cana");

Console.WriteLine("--- Recorrido Completo del Diccionario ---");
Console.WriteLine("Usando un bucle 'foreach' para mostrar todo:\n");
foreach (KeyValuePair<string, string> ciudad in ciudades)
{
    Console.WriteLine("Código (Clave): " + ciudad.Key + " | Ciudad (Valor): " + ciudad.Value);
}

Console.WriteLine("\n--- Fin del recorrido ---");
Console.WriteLine("Jades, presiona Enter para finalizar...");
Console.ReadLine();