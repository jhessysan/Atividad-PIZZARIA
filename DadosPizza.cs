using System;
public class DadosPizza
{
  //primeira pizza
public static string AdcionarNome()
{
           
  Console.WriteLine("Digite nome da pizza: ");
  var nomepizza = Console.ReadLine();
  List<String> listaNome = new List<String>();
  listaNome.Add(nomepizza);
  return nomepizza;
}
public static string AdcionarSabor()
{
  Console.WriteLine("Digite o sabor da pizza: ");
  var saborpizza = Console.ReadLine();
  List<String> listaSabor = new List<String>();
  listaSabor.Add(saborpizza);
  return saborpizza;
}
public static double AdcionarPreco()
{
  Console.WriteLine("Digite o preço da pizza: ");
  var precopizza = double.Parse(Console.ReadLine());
  List<double> listaPizzaPreco = new List<double>();
  listaPizzaPreco.Add(precopizza);
  return precopizza;
}
//segunda pizza
public static string AdcionarNome2()
{
           
  Console.WriteLine("Digite nome da pizza: ");
  var nomepizza2 = Console.ReadLine();
  List<String> listaNone2 = new List<String>();
  listaNone2.Add(nomepizza2);
  return nomepizza2;
}
public static string AdcionarSabor2()
{
  Console.WriteLine("Digite o sabor da pizza: ");
  var saborpizza2 = Console.ReadLine();
  List<String> listaSabor2 = new List<String>();
  listaSabor2.Add(saborpizza2);
  return saborpizza2;
}
public static double AdcionarPreco2()
{
  Console.WriteLine("Digite o preço da pizza: ");
  var precopizza2 = double.Parse(Console.ReadLine());
  List<double> listaPizzaPreco2 = new List<double>();
  listaPizzaPreco2.Add(precopizza2);
  return precopizza2;
}
public static double ListarPizza()
{
  Console.WriteLine("Digite 2 para listar pizza.");
  var listarp = double.Parse(Console.ReadLine());
  return listarp;
}
public static double CriarPedido()
{
  Console.WriteLine("Digite 3 para criar novo pedido.");
  var Criarp = double.Parse(Console.ReadLine());
  return Criarp;
}

}
 //modificado