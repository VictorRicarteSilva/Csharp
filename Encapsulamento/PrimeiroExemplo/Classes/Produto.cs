namespace ExercicioEstoque.Classes;

public class Produto
{
    private string _nome;
    private decimal _preco;
    private int _quantidade;

    public Produto(string nome, decimal preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome()
    {
        return _nome;
    }

    public void SetNome(string nome)
    {
        if (_nome != null && _nome.Length > 1)
        {
            _nome = nome;
        }
        else
        {
            Console.WriteLine("Nome invalido!");
        }
    }

    public decimal GetPreco()
    {
        return _preco;
    }

    public void SetPreco(decimal preco)
    {
        _preco = preco;
    }

    public int GetQuantidade()
    {
        return _quantidade;
    }

    public void SetQuantidade(int quantidade)
    {
        _quantidade = quantidade;
    }
    
    public decimal ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int new_quantidade)
    {
        _quantidade += new_quantidade;
    }    
    
    public void RemoverProdutos(int new_quantidade)
    {
        _quantidade -= new_quantidade;
    }

    public override string ToString()
    {
        return _nome + ", R$" + _preco.ToString("F") + ", " + _quantidade + " unidades, Total: R$" + ValorTotalEmEstoque().ToString("F");
    }
}