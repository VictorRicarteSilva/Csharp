namespace Exercicio1.Classes;

public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Largura * Altura;
    }

    public double Perimetro()
    {
        return (Altura * 2) + (Largura * 2);
    }

    public double Diagonal()
    {
        double diagonal;
        diagonal = Double.Sqrt(Double.Pow(Largura,2) + Double.Pow(Altura,2));
        return diagonal;
    }
}