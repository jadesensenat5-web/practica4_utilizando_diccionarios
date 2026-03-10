//2. Diccionario de tres productos con su precio e imprime el precio de uno de ellos.


Dictionary<string, double> productos = new Dictionary<string, double>();
productos.Add("Laptop", 1200.50);
productos.Add("Mouse", 25.99);
productos.Add("Teclado", 45.00);

Console.WriteLine("--- Buscador de Precios ---");
Console.WriteLine("Productos disponibles: Laptop, Mouse, Teclado");
Console.Write("\nEscribe el nombre del producto que quieres consultar: ");
string eleccion = Console.ReadLine();
if (productos.ContainsKey(eleccion))
{
    Console.WriteLine($"\nEl precio de '{eleccion}' es: ${productos[eleccion]}");
}
else
{
    Console.WriteLine("\nLo siento, ese producto no está en la lista.");
}
Console.WriteLine("\nPresiona Enter para finalizar...");
Console.ReadLine();