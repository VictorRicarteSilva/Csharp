using System.Globalization;
using System.Threading.Channels;

double TrianguloxLadoa;
double TrianguloxLadob;
double TrianguloxLadoc;

double TrianguloyLadoa;
double TrianguloyLadob;
double TrianguloyLadoc;

double areaX, areaY, pX, pY;

Console.WriteLine("Entre com as medidas do Triangulo X: ");
TrianguloxLadoa = Convert.ToDouble(Console.ReadLine());
TrianguloxLadob = Convert.ToDouble(Console.ReadLine());
TrianguloxLadoc = Convert.ToDouble(Console.ReadLine());

pX = (TrianguloxLadoa + TrianguloxLadob + TrianguloxLadoc) / 2;
areaX = Double.Sqrt(pX * (pX - TrianguloxLadoa) * (pX - TrianguloxLadob) * (pX - TrianguloxLadoc));

Console.WriteLine("Entre com as medidas do Triangulo Y: ");
TrianguloyLadoa = Convert.ToDouble(Console.ReadLine());
TrianguloyLadob = Convert.ToDouble(Console.ReadLine());
TrianguloyLadoc = Convert.ToDouble(Console.ReadLine());

pY = (TrianguloyLadoa + TrianguloyLadob + TrianguloyLadoc) / 2;
areaY =  Double.Sqrt(pY * (pY - TrianguloyLadoa) * (pY - TrianguloyLadob) * (pY - TrianguloyLadoc));

Console.WriteLine($"Area do triangulo X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Area do triangulo Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

if (areaX > areaY)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}