// See https://aka.ms/new-console-template for more information

using Resolucao2.Classes;

Calculadora c1 = new Calculadora();
Console.WriteLine("Entre com o valor do raio da circunferência: ");
double raio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Circunferência: {c1.CalculaCircunferencia(raio).ToString("F2")}");
Console.WriteLine($"Volume: {c1.CalculaVolume(raio).ToString("F2")}");
Console.WriteLine($"Valor de PI: {Math.PI.ToString("F2")}");