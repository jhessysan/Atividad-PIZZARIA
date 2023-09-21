public class DadosPizza2
{

    public Pizza2 CadastrarUmaPizza2()
    {
         //métodos
        Console.WriteLine("Digite nome da pizza: ");
        var nomepizza2 = Console.ReadLine();
        Console.WriteLine("Digite o sabor da pizza: ");
        var saborpizza2 = Console.ReadLine();
        
        Console.WriteLine("Digite o preço da pizza: ");
        var precopizza2 = Console.ReadLine();
        var conversaoPrecoPizza2 = Convert.ToDouble(precopizza2);

        
        var pizza2 = new Pizza2();
        pizza2.NomePizza2 = nomepizza2;
        pizza2.Saborpizza2 = saborpizza2;
        pizza2.PrecoPizza2 = conversaoPrecoPizza2;
        return pizza2;

        //Console.WriteLine($" A Pizza de {nome} tem sabor de {sabor} e custa {preco} $.");

    }

}