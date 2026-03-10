// 7. Diccionario de 3 elementos y comprueba si una clave específica existe en él.

Dictionary<string, string> paises = new Dictionary<string, string> {
            { "DO", "República Dominicana" },
            { "ES", "España" },
            { "FR", "Francia" }
        };

Console.WriteLine("--- Verificador de Claves ---");
Console.Write("Introduce el código a buscar (Ej: DO, ES, FR o uno que no exista): ");
string buscar = Console.ReadLine().ToUpper(); 
if (paises.ContainsKey(buscar))
{
    Console.WriteLine($"\n¡Encontrado! La clave '{buscar}' pertenece a: {paises[buscar]}");
}
else
{
    Console.WriteLine($"\nLa clave '{buscar}' NO existe en este diccionario.");
}

Console.WriteLine("\nPresiona Enter para finalizar...");
Console.ReadLine();
