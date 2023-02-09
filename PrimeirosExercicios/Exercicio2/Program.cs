using Exercicio2.Classes;

Pessoa pessoa1, pessoa2;
pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
pessoa1.nome = Console.ReadLine();
Console.Write("Salário: R$");
pessoa1.salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Dadps da segunda pessoa: ");
Console.Write("Nome: ");
pessoa2.nome = Console.ReadLine();
Console.Write("Salário: R$");
pessoa2.salario = Convert.ToDecimal(Console.ReadLine());

decimal salarioMedio;
salarioMedio = (pessoa1.salario + pessoa2.salario) / 2;

Console.WriteLine($"Salário médio: R${salarioMedio.ToString("F")}");