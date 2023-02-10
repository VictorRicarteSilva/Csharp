// See https://aka.ms/new-console-template for more information

Console.WriteLine("Entre com o valor do raio: ");
double raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Circunferência: {CalculaCircunferencia(raio).ToString("F")}");
Console.WriteLine($"Volume: {CalculaVolume(raio).ToString("F")}");
Console.WriteLine($"Valor de PI: {Math.PI.ToString("F")}");


static double CalculaCircunferencia(double raio)
{
    return 2.0 * (Math.PI * raio);
}

static double CalculaVolume(double raio)
{
    return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
}