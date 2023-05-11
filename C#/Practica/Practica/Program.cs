// See https://aka.ms/new-console-template for more information
//Ejercicio 1

Console.Write("Por favor ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola, " + nombre + "!");

//Ejercicio 2

DateTime horaActual = DateTime.Now;
Console.WriteLine("La hora actual es: " + horaActual.ToString("hh:mm:ss tt"));