namespace Resolucao3.Classes;

public class Calculadora
{
    public static double Pi = 3.14;
    public static double CalculaCircunferencia(double raio)
    {
        return 2.0 * (Pi * raio);
    }

   public static double CalculaVolume(double raio)
    {
        return (4.0 / 3.0) * Pi * Math.Pow(raio, 3);
    }
}