using System;

class DadosPessoa
{

    
    //atributos
    public string Nome;
    public string Endereco;
    public double NumeroTelefone;

    //métodos (funcões)
    public void entradaDadosPessoa()
    {
        Console.WriteLine("Digite seu nome: ");
        var nomePessoa = Console.ReadLine();
        Console.WriteLine("Digite o seu endereço: ");
        var endereco = Console.ReadLine();
        Console.WriteLine("Digite o seu telefone: ");
        var telefone = Console.ReadLine();

        Console.WriteLine ($"A Pizza de {Nome}");
        Console.WriteLine ($"Tem sabor de {Endereco}");
        Console.WriteLine ($"Custa {NumeroTelefone} $.");
    }

}