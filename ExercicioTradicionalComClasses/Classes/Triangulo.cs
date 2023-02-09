namespace ExercicioTradicionalComClasses.Classes;

public class Triangulo
{
    // atributos
    public double A;
    public double B;
    public double C;

    /// <summary>
    /// Usando a fórmula de Heron para calcular a área de um triângulo
    /// </summary>
    /// <returns> double area</returns>
    public double area()
    {
        double p = (A + B + C) / 2;
        
        return Double.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}