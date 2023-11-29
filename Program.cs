﻿using CLASSE1;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();


Console.WriteLine("Digite os valores dos lados do triangulo X");
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Digite os valores dos lados do triangulo Y");
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("A área de X = " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
Console.WriteLine("A área de Y = " + areaY.ToString("F4"), CultureInfo.InvariantCulture);