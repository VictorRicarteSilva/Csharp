using PrimeiroExemplo.Classes;

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = Convert.ToDouble(Console.ReadLine());
Console.Write("Quantidade: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

Produto p1 = new Produto(nome, preco, quantidade);

Console.WriteLine($"Dados do produto: {p1}");

int newQtd;

Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
newQtd = Convert.ToInt32(Console.ReadLine());
p1.AdicionarProdutos(newQtd);

Console.WriteLine($"Dados atualizados: {p1}");

Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
newQtd = Convert.ToInt32(Console.ReadLine());
p1.RemoverProdutos(newQtd);

Console.WriteLine($"Dados atualizados: {p1}");
