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

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
            else
            {
                Console.WriteLine("Nome invalido!");
            }
        }
    }

    public decimal Preco
    {
        get { return _preco; }
        set
        {
            _preco = value;
        }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set
        {
            _quantidade = value;
        }
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