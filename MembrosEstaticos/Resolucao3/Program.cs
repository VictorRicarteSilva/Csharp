using Resolucao3.Classes;

Console.WriteLine("Entre com o valor do raio: ");
double raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Circunferência: {Calculadora.CalculaCircunferencia(raio).ToString("F")}");
Console.WriteLine($"Volume: {Calculadora.CalculaVolume(raio).ToString("F")}");
Console.WriteLine($"Valor de PI: {Calculadora.Pi}");