public class DadosPizza
{

    public Pizza CadastrarUmaPizza()
    {
         //métodos
        Console.WriteLine("Digite nome da pizza: ");
        var nomepizza = Console.ReadLine();
        Console.WriteLine("Digite o sabor da pizza separados com virgula: ");
        var saborpizza = Console.ReadLine();
        
        Console.WriteLine("Digite o preço da pizza: ");
        var precopizza = double.Parse(Console.ReadLine());

        var pizza = new Pizza();
        pizza.NomePizza = nomepizza;
        pizza.Saborpizza = saborpizza;
        pizza.PrecoPizza = precopizza;
        return pizza;

    }

}
