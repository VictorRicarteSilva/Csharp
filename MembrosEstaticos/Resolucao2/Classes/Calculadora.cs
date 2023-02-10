namespace Resolucao2.Classes;

public class Calculadora
{
    public double CalculaCircunferencia(double raio)
    {
        return 2.0 * (Math.PI * raio);
    }

    public double CalculaVolume(double raio)
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
    }
}