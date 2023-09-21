public class CadastroPessoa
{

    public DadosPessoa CadastrarUmaPessoa()
    {
         //métodos
        Console.WriteLine("Digite o nome do cliente: ");
        var nomePessoa = Console.ReadLine();
        Console.WriteLine("Digite o endereço cliente: ");
        var endereco = Console.ReadLine();
        
        Console.WriteLine("Digite o telefone do cliente: ");
        var telefone = Console.ReadLine();
        var conversaoTelefone = Convert.ToDouble(telefone);

        var dadosPessoa = new DadosPessoa(); 
        dadosPessoa.Nome = nomePessoa;
        dadosPessoa.Endereco = endereco;
        dadosPessoa.NumeroTelefone = conversaoTelefone;
        return dadosPessoa;
    }
}