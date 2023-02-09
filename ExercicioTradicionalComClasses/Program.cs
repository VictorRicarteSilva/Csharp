// See https://aka.ms/new-console-template for more information

using ExercicioTradicionalComClasses.Classes;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

double areaX, areaY;

Console.WriteLine("Entre com as medidas do Triangulo X: ");
x.A = Convert.ToDouble(Console.ReadLine());
x.B = Convert.ToDouble(Console.ReadLine());
x.C = Convert.ToDouble(Console.ReadLine());

areaX = x.area();

Console.WriteLine("Entre com as medidas do Triangulo Y: ");
y.A = Convert.ToDouble(Console.ReadLine());
y.B = Convert.ToDouble(Console.ReadLine());
y.C = Convert.ToDouble(Console.ReadLine());

areaY = y.area();

Console.WriteLine($"Area do triangulo X = {areaX.ToString("F")}");
Console.WriteLine($"Area do triangulo Y = {areaY.ToString("F")}");

if (areaX > areaY)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}
