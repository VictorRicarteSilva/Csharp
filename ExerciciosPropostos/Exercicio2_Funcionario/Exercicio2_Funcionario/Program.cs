using Exercicio2_Funcionario.Classes;

Funcionario f1;
f1 = new Funcionario();

Console.Write("Nome: ");
f1.Nome = Console.ReadLine();
Console.Write("Salário bruto: R$");
f1.Salario = Convert.ToDecimal(Console.ReadLine());
Console.Write("Imposto R$");
f1.Imposto = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Funcionário: {f1}");

Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
decimal porcentagem;
porcentagem = Convert.ToDecimal(Console.ReadLine());
f1.aumento(porcentagem);

Console.WriteLine($"Dados atualizados: {f1}");