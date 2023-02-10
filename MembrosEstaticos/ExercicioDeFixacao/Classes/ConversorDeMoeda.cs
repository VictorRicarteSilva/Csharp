namespace ExercicioDeFixacao.Classes;

public class ConversorDeMoeda
{
    public static double IOF = (6.0 / 100);
    public static double ConverteDolar(double cotacao, double quantidade)
    {
        double total = cotacao * quantidade;
        return total + total * IOF;
    }
}