using System.Globalization;
using System;
using Calcular_area_do_triangulo;

// Calcular a area de um triango sem utilizar conceitos de POO.
//double xA, xB, xC, yA, yB, yC;

Triangulo x,y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Calcular Área do triangulo!");
Console.WriteLine("Entre com as medidas do triangulo X");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo Y");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.CalcularArea();

double areaY = y.CalcularArea();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
} else
{
    Console.WriteLine("Maior área: Y");
}