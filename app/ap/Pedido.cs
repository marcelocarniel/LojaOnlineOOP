
public class Pedido
{
    public Cliente Cliente { get; set; }
    public DateTime DataPedido { get; set; }
    public List<Produto> Produtos { get; set; }
    public string Status { get; set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        DataPedido = DateTime.Now;
        Produtos = new List<Produto>();
        Status = "Em Processamento";
        Console.WriteLine($"{Status}");
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto.Estoque > 0)
        {
            Produtos.Add(produto);
            produto.Estoque--;
            Console.WriteLine($"Produto {produto.Nome} adicionado ao pedido. Estoque restante: {produto.Estoque}");
        }
        else
        {
            Console.WriteLine($"Produto {produto.Nome} está fora de estoque.");
        }
    }

    public void RemoverProduto(Produto produto)
    {
        if (Produtos.Contains(produto))
        {
            Produtos.Remove(produto);
            produto.Estoque++;
            Console.WriteLine($"Produto {produto.Nome} removido do pedido. Estoque atualizado: {produto.Estoque}");
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        Status = "Concluído";
        Console.WriteLine($"Pedido {Status} as {DataPedido}");
    }
}


