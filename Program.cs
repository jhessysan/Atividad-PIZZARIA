
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
            Console.WriteLine("BEM VINDO A PIZZARIA LASABOR. \n ESCOLA UMA OPÇÃO: \n 1/Adcionar Pizza. \n 2/Listar Pizza. \n 3/Criar novo pedido. \n 4/Listar pedido. \n 5/Pagar pedido. ");
            var opcoes = double.Parse(Console.ReadLine());
           
          
           
           if(opcoes == 1)
            {           
           //Instanciar (criando objeto)

            DadosPizza piz = new DadosPizza();

            var pizza = piz.CadastrarUmaPizza();
            Console.WriteLine();//impressão vazio para da espaço

            Console.WriteLine("Pizza criada.");
            Console.WriteLine("Digite 2 para listar pedido.");
            var opcao2 = double.Parse(Console.ReadLine());
            
            
                
           


            if(opcao2 == 2)
            {
                
                Console.WriteLine();//impressão vazio para da espaço

                //primeira pizza
                Console.WriteLine($"Nome da pizza: {pizza.NomePizza}");
                Console.WriteLine($"Sabor: {pizza.Saborpizza}");
                Console.WriteLine($"Preço: {pizza.PrecoPizza}$");

                 Console.WriteLine("Deseja adcionar outra pizza digite 1/Sim 2/Não.");
                var opcao3 = double.Parse(Console.ReadLine());
            
                    

            
            if(opcao3 == 1)
            {
                 DadosPizza2 piz2 = new DadosPizza2();

                var pizza2 = piz2.CadastrarUmaPizza2();
                Console.WriteLine();//impressão vazio para da espaço

                Console.WriteLine("Pizza criada.");
                Console.WriteLine("Digite 2 para listar pizza.");
                var opcao4 = double.Parse(Console.ReadLine());
                
            if(opcao4 == 2){

                //segunda pizza
                Console.WriteLine($"Nome da pizza: {pizza2.NomePizza2}");
                Console.WriteLine($"Sabor: {pizza2.Saborpizza2}");
                Console.WriteLine($"Preço: {pizza2.PrecoPizza2}$");

                 Console.WriteLine("Digite 4 para listar pedido");
                var opcao5 = double.Parse(Console.ReadLine());
            

            
            if(opcao5 ==4 || opcao3 == 2)
            {
                CadastroPessoa cadas = new CadastroPessoa();
                var dadosPessoa = cadas.CadastrarUmaPessoa();
                Console.WriteLine();//impressão vazio para da espaço
                Console.WriteLine("PEDIDO PRONTO!");

                Console.WriteLine();//impressão vazio para da espaço
                Console.WriteLine($"Cliente: {dadosPessoa.Nome}");
                Console.WriteLine($"Endereço: {dadosPessoa.Endereco}");
                Console.WriteLine($"Telefone: {dadosPessoa.NumeroTelefone}");
                //primeira pizza
                Console.WriteLine($"Nome da pizza: {pizza.NomePizza}");
                Console.WriteLine($"Sabor: {pizza.Saborpizza}");
                Console.WriteLine($"Preço: {pizza.PrecoPizza}$");
                //segunda pizza
                Console.WriteLine($"Nome da segunda pizza: {pizza2.NomePizza2}");
                Console.WriteLine($"Sabor: {pizza2.Saborpizza2}");
                Console.WriteLine($"Preço: {pizza2.PrecoPizza2}$");
                Console.WriteLine();//impressão vazio para da espaço
                Console.WriteLine($"Valor total: {pizza2.PrecoPizza2 + pizza.PrecoPizza}$");
                Console.WriteLine();//impressão vazio para da espaço

                Console.WriteLine("ESCOLHA A FORMA DE PAGAMENTO: \n 1/Dinheiro. \n2/Cartão. \n3/Vale-refeição. ");
                var opcao6 = double.Parse(Console.ReadLine());
         
            if(opcao6 == 1)
            {
                Console.WriteLine("Pagamento em dinheiro.");
                Console.WriteLine("PAGAMENTO FEITO COM SUCESSO!");
                Console.WriteLine();//impressão vazio para da espaço
            }
            else if(opcao6 == 2)
            {
                Console.WriteLine("Pagamento com cartão.");
                Console.WriteLine("PAGAMENTO FEITO COM SUCESSO!");
                Console.WriteLine();//impressão vazio para da espaço
            }
            else if(opcao6 == 3)
            {
                Console.WriteLine("Pagamento com vale-refeição.");
                Console.WriteLine("PAGAMENTO FEITO COM SUCESSO!");
                Console.WriteLine();//impressão vazio para da espaço
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
}
}
}

