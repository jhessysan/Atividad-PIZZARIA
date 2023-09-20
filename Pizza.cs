using System;

class Pizza
{
    //atributos
    public string Nome;
    public string Sabor;
    public double Preco;

    //métodos (funcões)
    public void entradaDados()
    {
        Console.WriteLine("Digite nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite o sabor: ");
        var sabor = Console.ReadLine();
        Console.WriteLine("Digite o preço: ");
        var preco = Console.ReadLine();

        Console.WriteLine($" A Pizza de {nome} tem sabor de {sabor} e custa {preco} $.");
    }
   
}