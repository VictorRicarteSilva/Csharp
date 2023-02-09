using Exercicio1.Classes;

Console.WriteLine("Entre com a largura e altura do retângulo: ");

Retangulo r1;
r1 = new Retangulo();

r1.Largura = Convert.ToDouble(Console.ReadLine());
r1.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Área: {r1.Area().ToString("F")}");
Console.WriteLine($"Perimetro: {r1.Perimetro().ToString("F")}");
Console.WriteLine($"Diagonal: {r1.Diagonal().ToString("F")}");