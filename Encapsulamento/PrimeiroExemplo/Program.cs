// See https://aka.ms/new-console-template for more information

using ExercicioEstoque.Classes;

Produto p = new Produto("Notbook", 5500,10);

Console.WriteLine(p.GetNome());
Console.WriteLine(p.GetPreco());
Console.WriteLine(p.GetQuantidade());

p.SetNome("Lenovo");
p.SetPreco(3000);
p.SetQuantidade(15);

Console.WriteLine(p);