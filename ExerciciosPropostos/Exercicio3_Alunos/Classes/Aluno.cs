namespace Exercicio3_Alunos.Classes;

public class Aluno
{
    public string Nome;
    public double Nota1, Nota2, Nota3;

    public double NotaFinal()
    {
        return (Nota1 + Nota2 + Nota3);
    }

    public void aprovadoOuNao()
    {
        if (NotaFinal() < 60)
        {
            Console.WriteLine($"Reprovado!\nFaltaram {(60 - NotaFinal()).ToString("F")} pontos");
        }
        else
        {
            Console.WriteLine("Aprovado");
        }
    }
}