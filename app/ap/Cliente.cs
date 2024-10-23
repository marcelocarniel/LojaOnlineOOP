public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    
    public Cliente(string nome, string numeroIdentificacao)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
       
    }

}
