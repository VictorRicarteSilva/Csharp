using ExercicioEstoque.Classes;

Produto produto1;
produto1 = new Produto();
int qtd;

Console.WriteLine("Entre com os dados do produto: ");

Console.Write("Nome: ");
produto1.Nome = Console.ReadLine();

Console.Write("Preço: R$");
produto1.Preco = Convert.ToDecimal(Console.ReadLine());

Console.Write("Quantidade: ");
produto1.Quantidade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Dados do produto: {produto1}");

Console.Write("Digite o numero de itens a ser adicionado ao estoque: ");
qtd = Convert.ToInt32(Console.ReadLine());
produto1.AdicionarProdutos(qtd);

Console.WriteLine($"Dados atualizados: {produto1}");

Console.Write("Digite o numero de itens a ser removido ao estoque: ");
qtd = Convert.ToInt32(Console.ReadLine());
produto1.RemoverProdutos(qtd);

Console.WriteLine($"Dados atualizados: {produto1}");

