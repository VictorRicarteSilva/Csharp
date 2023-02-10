namespace Exercicio2_Funcionario.Classes;

public class Funcionario
{
    public string Nome;
    public decimal Salario;
    public decimal Imposto;

    public decimal SalarioLiquido()
    {
        return Salario - Imposto;
    }

    public void aumento(decimal porcentagem)
    {
        Salario *= (1 + porcentagem / 100);
    }

    public override string ToString()
    {
        return Nome + ", R$" + SalarioLiquido().ToString("F");
    }
}