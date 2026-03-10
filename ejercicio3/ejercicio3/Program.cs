// 3. Diccionario con tres estudiantes y sus calificaciones, y modifica la calificación de uno de ellos.

Dictionary<string, int> estudiantes = new Dictionary<string, int>();
estudiantes.Add("Juan", 85);
estudiantes.Add("Maria", 92);
estudiantes.Add("Pedro", 78);
Console.WriteLine("--- Sistema de Calificaciones ---");
Console.WriteLine("Estudiantes: Juan, Maria, Pedro");
Console.Write("\n¿A qué estudiante deseas modificarle la nota?: ");
string nombre = Console.ReadLine();
if (estudiantes.ContainsKey(nombre))
{
    Console.WriteLine($"Nota actual de {nombre}: {estudiantes[nombre]}");
    Console.Write($"Introduce la nueva calificación para {nombre}: ");
    int nuevaNota = int.Parse(Console.ReadLine()); 
    estudiantes[nombre] = nuevaNota;
    Console.WriteLine($"\n¡Éxito! La nueva nota de {nombre} es: {estudiantes[nombre]}");
}
else
{
    Console.WriteLine("\nEl estudiante no existe en el registro.");
}
Console.WriteLine("\nPresiona Enter para finalizar...");
Console.ReadLine();