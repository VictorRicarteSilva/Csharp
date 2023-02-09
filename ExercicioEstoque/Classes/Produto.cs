namespace ExercicioEstoque.Classes;

public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public decimal ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int newQuantidade)
    {
        Quantidade += newQuantidade;
    }    
    
    public void RemoverProdutos(int newQuantidade)
    {
        Quantidade -= newQuantidade;
    }

    public override string ToString()
    {
        return Nome + ", R$" + Preco.ToString("F") + ", " + Quantidade + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F");
    }
}