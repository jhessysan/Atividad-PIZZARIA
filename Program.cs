
using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;


namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           //Entrada de informação do ususario
            Console.WriteLine("BEM VINDO A PIZZARIA LASABOR");
            Console.WriteLine();//impressão vazio para da espaço

            Console.WriteLine("ESCOLA UMA OPÇÃO: ");
            Console.WriteLine("1/Adcionar Pizza. ");
            Console.WriteLine("2/Listar Pizza. ");
            Console.WriteLine("3/Criar novo pedido. ");
            Console.WriteLine("4/Listar pedido. ");
            var opcao = Console.ReadLine();
            var conversaoOpcao = Convert.ToDouble(opcao);
            Console.WriteLine($"Opção: {conversaoOpcao}");
           
          
           
           if(conversaoOpcao == 1)
            {           
           //Instanciar (criando objeto)

            DadosPizza piz = new DadosPizza();

            var pizza = piz.CadastrarUmaPizza();
            Console.WriteLine();//impressão vazio para da espaço

            Console.WriteLine("Pizza criada.");
            Console.WriteLine("Deseja fazer outra piazza? 1/Sim e 2/Não");
            var opcao2 = Console.ReadLine();
            var conversaoOpcao2 = Convert.ToDouble(opcao2);
            
                
           

           
            if(conversaoOpcao2 == 1)
            {
                DadosPizza2 piz1 = new DadosPizza2();

                var pizza2 = piz1.CadastrarUmaPizza2();
                Console.WriteLine();//impressão vazio para da espaço

                Console.WriteLine("Pizza criada.");
                Console.WriteLine("Deseja fazer outra piazza? 1/Sim e 2/Não");
                var opcao3 = Console.ReadLine();
                var conversaoOpcao3 = Convert.ToDouble(opcao3);
            

             if(conversaoOpcao3 == 2)
            {
                //DadosPizza piz = new DadosPizza();
                //var pizza = piz.CadastrarUmaPizza();
                Console.WriteLine();//impressão vazio para da espaço

                //primeira pizza
                Console.WriteLine($"Nome da pizza: {pizza.NomePizza}");
                Console.WriteLine($"Sabor: {pizza.Saborpizza}");
                Console.WriteLine($"Preço: {pizza.PrecoPizza}");
            
                //segunda pizza
                Console.WriteLine($"Nome da pizza: {pizza2.NomePizza2}");
                Console.WriteLine($"Sabor: {pizza2.Saborpizza2}");
                Console.WriteLine($"Preço: {pizza2.PrecoPizza2}");
                    

            }
            else if(conversaoOpcao ==4)
            {
                CadastroPessoa cadas = new CadastroPessoa();
                var dadosPessoa = cadas.CadastrarUmaPessoa();

                Console.WriteLine();//impressão vazio para da espaço
                Console.WriteLine($"Cliente: {dadosPessoa.Nome}");
                Console.WriteLine($"Endereço: {dadosPessoa.Endereco}");
                Console.WriteLine($"Telefone: {dadosPessoa.NumeroTelefone}");

                

            }
            else
            {
                Console.WriteLine("Digite apenas '1', '2', '3' ou '4', e um por vez confome a sua escolha!");
            }

        }
    }
}
}
}