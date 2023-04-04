// See https://aka.ms/new-console-template for more information


using Clase1.Logica;

Console.WriteLine("Ingrese 2 numeros: ");
Console.WriteLine("Nro 1: ");
String nro1 = Console.ReadLine();

Console.WriteLine("Nro 2: ");
String nro2 = Console.ReadLine();

// tring interrpolaion $"texto {{variable}"
Console.WriteLine($"La suma de estos nros es: {Calculadora.Sumar(nro1, nro2)} ");

//Console.WriteLine($"La suma de estos nros es: {(int.Parse(nro1) + (int.Parse(nro2)))} ");

//Console.WriteLine("La suma de estos nros es:" + (int.Parse(nro1) + (int.Parse(nro2))));