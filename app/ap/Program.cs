class Program
{
    static void Main()
    {
        Loja loja = new Loja();

        Produto produtoFisico1 = new ProdutoFisico("Iphone", "P1", 5000m, 2, "Eletrônicos", 0);
        Produto produtoFisico2 = new ProdutoFisico("Notebook Dell", "P2", 4000m, 5, "Eletrônicos", 50);
        Produto produtoFisico3 = new ProdutoFisico("Monitor Samsung", "P3", 1200m, 10, "Eletrônicos", 14);

        Produto produtoDigital1 = new ProdutoDigital("GtaV", "P4", 300m, 500000, "Arquivos", 10);
        Produto produtoDigital2 = new ProdutoDigital("Office 365", "P5", 200m, 10000, "Software", 15);
        Produto produtoDigital3 = new ProdutoDigital("Curso de C#", "P6", 150m, 1000, "Educação", 22);

        loja.CadastrarProduto(produtoFisico1);
        loja.CadastrarProduto(produtoFisico2);
        loja.CadastrarProduto(produtoFisico3);

        loja.CadastrarProduto(produtoDigital1);
        loja.CadastrarProduto(produtoDigital2);
        loja.CadastrarProduto(produtoDigital3);

        Cliente cliente1 = new Cliente("Marcelo", "123456789");
        loja.CadastrarCliente(cliente1);

        Cliente cliente2 = new Cliente("Lucas", "544848465");
        loja.CadastrarCliente(cliente2);

        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(produtoFisico2);
        pedido1.AdicionarProduto(produtoFisico1);
        pedido1.AdicionarProduto(produtoDigital3);
        pedido1.RemoverProduto(produtoFisico1);

        Console.WriteLine($"Total do pedido de {cliente1.Nome} é {pedido1.CalcularTotal()}");
        pedido1.FinalizarPedido();

        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(produtoFisico2);
        pedido2.AdicionarProduto(produtoDigital1);
        pedido2.AdicionarProduto(produtoDigital3);
        pedido2.AdicionarProduto(produtoDigital2);

        Console.WriteLine($"Total do pedido de {cliente2.Nome} é {pedido2.CalcularTotal()}");
        pedido2.FinalizarPedido();
    }
}
