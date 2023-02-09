// See https://aka.ms/new-console-template for more information

using ExercicioTradicionalComClasses.Classes;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

double areaX, areaY, pX, pY;

Console.WriteLine("Entre com as medidas do Triangulo X: ");
x.A = Convert.ToDouble(Console.ReadLine());
x.B = Convert.ToDouble(Console.ReadLine());
x.C = Convert.ToDouble(Console.ReadLine());

pX = (x.A + x.B + x.C) / 2;
areaX = Double.Sqrt(pX * (pX - x.A) * (pX - x.B) * (pX - x.C));

Console.WriteLine("Entre com as medidas do Triangulo Y: ");
y.A = Convert.ToDouble(Console.ReadLine());
y.B = Convert.ToDouble(Console.ReadLine());
y.C = Convert.ToDouble(Console.ReadLine());

pY = (y.A + y.B + y.C) / 2;
areaY =  Double.Sqrt(pY * (pY - y.A) * (pY - y.B) * (pY - y.C));

Console.WriteLine($"Area do triangulo X = {areaX.ToString("F4")}");
Console.WriteLine($"Area do triangulo Y = {areaY.ToString("F4")}");

if (areaX > areaY)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}
