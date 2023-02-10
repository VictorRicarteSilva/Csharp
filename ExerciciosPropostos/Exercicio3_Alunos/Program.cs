using Exercicio3_Alunos.Classes;

Aluno a1;
a1 = new Aluno();

Console.Write("Nome do aluno: ");
a1.Nome = Console.ReadLine();

Console.WriteLine("Digite as 3 Notas do aluno: ");
a1.Nota1 = Convert.ToDouble(Console.ReadLine());
a1.Nota2 = Convert.ToDouble(Console.ReadLine());
a1.Nota3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Nota final = {a1.NotaFinal().ToString("F")}");
a1.aprovadoOuNao();