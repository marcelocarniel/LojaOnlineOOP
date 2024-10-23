

public class Loja
{
    public List<Produto> Produtos { get; set; } = new List<Produto>();
    public List<Cliente> Clientes { get; set; } = new List<Cliente>();

    public void CadastrarProduto(Produto produto)
    {
        Produtos.Add(produto);
        Console.WriteLine("Produto cadastrado: " + produto.Nome);
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        foreach (var produto in Produtos)
        {
            if (produto.Codigo == codigo)
            {
                return produto;
            }
        }
        return null; 
    }

    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado: " + cliente.Nome);
    }

    public Cliente ConsultarClientePorID(string id)
    {
        foreach (var cliente in Clientes)
        {
            if (cliente.NumeroIdentificacao == id)
            {
                return cliente;
            }
        }
        return null; 
    }
}

