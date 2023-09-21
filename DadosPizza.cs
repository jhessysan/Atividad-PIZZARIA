public class DadosPizza
{

    public Pizza CadastrarUmaPizza()
    {
         //métodos
        Console.WriteLine("Digite nome da pizza: ");
        var nomepizza = Console.ReadLine();
        Console.WriteLine("Digite o sabor da pizza: ");
        var saborpizza = Console.ReadLine();
        
        Console.WriteLine("Digite o preço da pizza: ");
        var precopizza = Console.ReadLine();
        var conversaoPrecoPizza = Convert.ToDouble(precopizza);

        var pizza = new Pizza();
        pizza.NomePizza = nomepizza;
        pizza.Saborpizza = saborpizza;
        pizza.PrecoPizza = conversaoPrecoPizza;
        return pizza;
        

        //Console.WriteLine($" A Pizza de {nome} tem sabor de {sabor} e custa {preco} $.");

    }

}
