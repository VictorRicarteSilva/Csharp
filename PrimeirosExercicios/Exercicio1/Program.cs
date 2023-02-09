using Exercicio1.Classes;

Pessoa pessoa1, pessoa2;
pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome: ");
pessoa1.nome = Convert.ToString(Console.ReadLine());
Console.Write("Idade: ");
pessoa1.idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.Write("Nome: ");
pessoa2.nome = Convert.ToString(Console.ReadLine());
Console.Write("Idade: ");
pessoa2.idade = Convert.ToInt32(Console.ReadLine());

if (pessoa1.idade > pessoa2.idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa1.nome}");
}else if (pessoa2.idade > pessoa1.idade)
{
    Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}");
}
else
{
    Console.WriteLine("Ambos possuem a mesma idade!");
}