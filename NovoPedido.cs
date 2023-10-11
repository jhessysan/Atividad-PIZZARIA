using System;
using System.Text;
public class  NovoPedido
{
public static string AdcionarNomeCliente()
{
           
    Console.WriteLine("Digite o nome do(a) Cliente: ");
    var nomeCliente = Console.ReadLine();
    return nomeCliente;
}
public static string AdcionarNumeroTelefone()
{
           
    Console.WriteLine("Digite o numero de telefone do(a) Cliente: ");
    var numeroTelefone = Console.ReadLine();
    return numeroTelefone;
}



public static double EscolherOutraPizza()
{  
    Console.WriteLine("Deseja adcionar mais uma pizza? 1/Sim e 2/Não");
    var pizzaEscolhida2 = double.Parse(Console.ReadLine());
    return pizzaEscolhida2;
}

public static double ListarPedido()
{
           
    Console.WriteLine("Digite 4 para listar pedido ");
    var listarP = double.Parse(Console.ReadLine());
    return listarP;
}

public static double ListarPedidao()
{
           
    Console.WriteLine("Digite 4 para listar pedido");
    var listarP2 = double.Parse(Console.ReadLine());
    return listarP2;
}

}
//modificado