public abstract class Produto
{
    public string Nome { get;  set; }
    public string Codigo { get;  set; }
    public decimal Preco { get;  set; }
    public int Estoque { get;  set; }

    public Produto(string nome, string codigo, decimal preco, int estoque)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        Estoque = estoque;
    }

   

    public abstract decimal CalcularPrecoFinal();
}