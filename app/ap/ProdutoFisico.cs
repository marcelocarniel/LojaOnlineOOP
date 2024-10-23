public class ProdutoFisico : Produto
{
    public double Peso { get; set; }
    public string Categoria { get; set; }

    public ProdutoFisico(string nome, string codigo, decimal preco, double peso, string categoria, int estoque )
        : base(nome, codigo, preco, estoque)
    {
        Peso = peso;
        Categoria = categoria;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaImposto = 0.1m; 
        decimal custoEnvio = (decimal)(Peso * 2); 
        return Preco + (Preco * taxaImposto) + custoEnvio;
    }
}