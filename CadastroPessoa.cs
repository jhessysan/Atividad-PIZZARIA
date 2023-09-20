public class CadastroPessoa
{

    public DadosPessoa CadastrarUmaPessoa()
    {
        Console.WriteLine("Digite seu nome: ");
        var nomePessoa = Console.ReadLine();
        Console.WriteLine("Digite o seu endereço: ");
        var endereco = Console.ReadLine();
        Console.WriteLine("Digite o seu telefone: ");
        var telefone = Console.ReadLine();

        var dadosPessoa = new DadosPessoa(); 
        dadosPessoa.Nome = nomePessoa;
        dadosPessoa.Endereco = endereco;
        dadosPessoa.NumeroTelefone = telefone;
        return dadosPessoa;
    }
}