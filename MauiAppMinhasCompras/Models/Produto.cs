using SQLite;

namespace MauiAppMinhasCompras.Models;

public class Produto
{
    private string _descricao;
    private double _quantidade;
    private double _preco;

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Descricao
    {
        get => _descricao;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O campo descrição é obrigatório");
            }
            _descricao = value;
        }
    }

    public double Quantidade
    {
        get => _quantidade;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Insira um valor válido para a quantidade");
            }
            _quantidade = value;
        }
    }

    public double Preco
    {
        get => _preco;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Insira um valor válido para o preço");
            }
            _preco = value;
        }
    }
    public double Total { get => Quantidade * Preco; }
}
