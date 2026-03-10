// 4. Crea un diccionario con tres claves y elimina una de ellas.

Dictionary<string, string> usuarios = new Dictionary<string, string>();
usuarios.Add("USR01", "Juan Pérez");
usuarios.Add("USR02", "María López");
usuarios.Add("USR03", "Pedro Martínez");

Console.WriteLine("--- Lista de Usuarios Actuales ---");
foreach (var user in usuarios)
{
    Console.WriteLine($"ID: {user.Key} | Nombre: {user.Value}");
}
Console.Write("\nEscribe el ID que deseas ELIMINAR: ");
string idAEliminar = Console.ReadLine();
if (usuarios.ContainsKey(idAEliminar))
{
    usuarios.Remove(idAEliminar); 
    Console.WriteLine($"\n¡Éxito! El usuario con ID '{idAEliminar}' ha sido eliminado.");
}
else
{
    Console.WriteLine("\nError: Ese ID no existe en el sistema.");
}
Console.WriteLine("\n--- Lista Actualizada ---");
foreach (var user in usuarios)
{
    Console.WriteLine($"ID: {user.Key} | Nombre: {user.Value}");
}
Console.WriteLine("\nPresiona Enter para finalizar...");
Console.ReadLine();