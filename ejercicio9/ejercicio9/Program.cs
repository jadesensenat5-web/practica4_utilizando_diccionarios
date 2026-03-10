// 9.Diccionario de 4 elementos y calcula la suma de todos los valores numéricos que contiene

Dictionary<string, double> facturacion = new Dictionary<string, double>();
facturacion.Add("Servicio de Internet", 2500.00);
facturacion.Add("Energía Eléctrica", 1850.50);
facturacion.Add("Agua Potable", 450.00);
facturacion.Add("Mantenimiento", 1200.00);
Console.WriteLine("--- Cálculo de Gastos Totales ---");
Console.WriteLine("Listado de cargos detectados:");
double sumaTotal = 0;
foreach (double monto in facturacion.Values)
{
    Console.WriteLine("Monto: $" + monto);
    sumaTotal += monto; 
}
Console.WriteLine("---------------------------------");
Console.WriteLine("LA SUMA TOTAL ES: $" + sumaTotal);
Console.WriteLine("---------------------------------");
Console.WriteLine("\n¡Felicidades Jades! Has terminado los 9 ejercicios.");
Console.WriteLine("Presiona Enter para cerrar...");
Console.ReadLine();