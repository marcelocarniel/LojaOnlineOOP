public class ProdutoDigital : Produto
{
    public double TamanhoArquivo { get; set; }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, string codigo, decimal preco, double tamanhoArquivo, string formato, int estoque)
        : base(nome, codigo, preco, estoque)
    {
        Nome = nome;
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal desconto = 0.1m;
        return Preco - (Preco * desconto);
    }
}