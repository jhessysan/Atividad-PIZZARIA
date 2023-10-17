﻿using System;
using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            double entrada = 0;
            while(entrada != 1)
            {
            Console.WriteLine("BEM VINDO A PIZZARIA LASABOR \n ESCOLA UMA OPÇÃO: \n 1/Adcionar Pizza. \n 2/Listar Pizza. \n 3/Criar novo pedido. \n 4/Listar pedido.");
            var opcao = double.Parse(Console.ReadLine());
            if(opcao == 1)
            {
                //primeira pizza
                Console.WriteLine($"OPÇÃO: {opcao}");
                Console.WriteLine();//vazio para espaço
                string oNome = DadosPizza.AdcionarNome();
                string oSabor = DadosPizza.AdcionarSabor();
                double oPreco = DadosPizza.AdcionarPreco();
                //segunda pizza
                string oNome2 = DadosPizza.AdcionarNome2();
                string oSabor2 = DadosPizza.AdcionarSabor2();
                double oPreco2 = DadosPizza.AdcionarPreco2();
                double listar = DadosPizza.ListarPizza();
                Console.WriteLine("PIZZA CRIADA COM SUCESSO! ");    
            if( listar == 2){
                //primeira pizza
                Console.WriteLine($"OPÇÃO: {listar}");
                Console.WriteLine();//vazio para espaço
                Console.WriteLine($"O nome da Pizza é {oNome}.");
                Console.WriteLine($"O sabor da pizza é {oSabor}.");
                Console.WriteLine($"O preço da pizza é {oPreco}$.");
                Console.WriteLine();//vazio para espaço
                //segunda pizza
                Console.WriteLine($"O nome da Pizza é {oNome2}.");
                Console.WriteLine($"O sabor da pizza é {oSabor2}.");
                Console.WriteLine($"O preço da pizza é {oPreco2}$.");
                Console.WriteLine();//vazio para espaço 
                double criarPedido = DadosPizza.CriarPedido();
            if(criarPedido == 3)
            {   //dados do cliente
                string nomeDoCliente = NovoPedido.AdcionarNomeCliente();
                string numeroDoCliente = NovoPedido.AdcionarNumeroTelefone();
                //adcionando pizza
                Console.WriteLine($"Escolha uma pizza para adcionar. \n 0-{oNome}-R${oPreco} \n 1-{oNome2}-R${oPreco2}");
                var pesc = int.Parse(Console.ReadLine());
                List<string> listaPizzaEsc = new List<string>();
                List<double> listaPizzaEsc2 = new List<double>();
                listaPizzaEsc.Add(oNome);
                listaPizzaEsc.Add(oNome2);
                listaPizzaEsc2.Add(oPreco);
                listaPizzaEsc2.Add(oPreco2);   
                Console.WriteLine($"OPÇÃO: {pesc} - {listaPizzaEsc[pesc]}");
                //adcionar outra pizza
                double pe = NovoPedido.EscolherOutraPizza();
                if(pe == 2)
                {
                    double pdao = NovoPedido.ListarPedidao();
                    if(pdao == 4)
                    {//pedido com uma pizza
                    Console.WriteLine($"PEDIDO {pe}");
                    Console.WriteLine($"O nome do(a) Cliente é {nomeDoCliente}.");
                    Console.WriteLine($"O numero do(a) Cliente é {numeroDoCliente}.");
                    Console.WriteLine($"{listaPizzaEsc[pesc]}-RS{listaPizzaEsc2[pesc]}");}
                    Console.WriteLine($"Total: {listaPizzaEsc2[pesc]}");
                    Console.WriteLine($"Quanto falta para pagar: {listaPizzaEsc2[pesc]}");
                    Console.WriteLine("pago: NÃO");
                    Console.WriteLine($"Qual é o numero do pedido:");
                    Console.WriteLine($"{pe} - Cliente: {nomeDoCliente} - Falta: R${listaPizzaEsc2[pesc]}");
                    Console.WriteLine("Escolha uma forma de pagamento? \n 1/Dinheiro \n2/Cartão de debito. \n3/vale-refeição.");
                    var pag = double.Parse(Console.ReadLine());
                    //pagamentos de uma pizza
                        if(pag == 1){
                                Pagamento.PagarEmDinheiro($"Qual é o valor:\nR${listaPizzaEsc2[pesc]}\nTOTAL PAGO: R${listaPizzaEsc2[pesc]}");
                            }else if(pag == 2){
                                 //Pagamento pagamento = new Pagamento();
                                Pagamento.PagarComCartaoCredito($"Qual é o valor:\n R${listaPizzaEsc2[pesc]}\nTOTAL PAGO: R${listaPizzaEsc2[pesc]}");
                            }else if(pag == 3){
                                Pagamento.PagarComCartaoAlimentacao($"Qual é o valor:\n R${listaPizzaEsc2[pesc]}\nTOTAL PAGO: R${listaPizzaEsc2[pesc]}");
                            }else{Console.WriteLine("Opção invalida");}
                            Console.WriteLine();
                }                   
            else if(pe == 1)
            {
                    Console.WriteLine($"Escolha uma pizza para adcionar. \n 0-{oNome}-R${oPreco} \n 1-{oNome2}-R${oPreco2}");
                    var pesc3 = int.Parse(Console.ReadLine());
                    List<string> listaPizzaEsc3 = new List<string>();
                    List<double> listaPizzaEsc4 = new List<double>();
                    listaPizzaEsc3.Add(oNome);
                    listaPizzaEsc3.Add(oNome2);
                    listaPizzaEsc4.Add(oPreco);
                    listaPizzaEsc4.Add(oPreco2);   
                    Console.WriteLine($"OPÇÃO: {pesc3} - {listaPizzaEsc[pesc3]}");
                    //var pizzaEscolhida3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite 2 para confiemar pedido.");
                    var listarPedidao = int.Parse(Console.ReadLine());          
            if(listarPedidao == 2){
                        double listarPedido = NovoPedido.ListarPedido();
                    if(listarPedido == 4 || pesc == 2)
                    {                        
                        if(pe == 1)
                        {  //pedido com duas pizza
                            Console.WriteLine($"O nome do(a) Cliente é {nomeDoCliente}.");
                            Console.WriteLine($"O numero do(a) Cliente é {numeroDoCliente}.");
                            Console.WriteLine($"{listaPizzaEsc[pesc]}-RS{listaPizzaEsc2[pesc]}");
                            Console.WriteLine($"{listaPizzaEsc3[pesc3]}-RS{listaPizzaEsc4[pesc3]}");
                            //soma das entrada de valores
                            double soma = Pagamento.Soma(listaPizzaEsc2[pesc], listaPizzaEsc4[pesc3]);
                            //pergunta antes do pagamento
                            Console.WriteLine($"Total: {soma}");
                            Console.WriteLine($"Quanto falta para pagar: {soma}");
                            Console.WriteLine("pago: NÃO");
                            Console.WriteLine($"Qual é o numero do pedido:");
                            Console.WriteLine($"{pe} - Cliente: {nomeDoCliente} - Falta: R$ {soma}");
                            Console.WriteLine("Escolha uma forma de pagamento? \n 1/Dinheiro \n2/Cartão de debito. \n3/vale-refeição.");
                            var pag = double.Parse(Console.ReadLine());
                            //pagamento com duas pizza
                            if(pag == 1){
                                Pagamento.PagarEmDinheiro($"Qual é o valor:\nR$ {soma}\nTOTAL PAGO: R$ {soma}");
                            }else if(pag == 2){
                                 //Pagamento pagamento = new Pagamento();
                                Pagamento.PagarComCartaoCredito($"Qual é o valor:\n R$ {soma}\nTOTAL PAGO: R$ {soma}");
                            }else if(pag == 3){
                                Pagamento.PagarComCartaoAlimentacao($"Qual é o valor:\n R$ {soma}\nTOTAL PAGO: R$ {soma}");
                            }else{Console.WriteLine("Opção invalida");}
                             Console.WriteLine();   
                    }
                }    
            }
        }
    }
}
}else{
    Console.WriteLine("ERRO: adcione uma pizza antes de escolher outra opção!");
    Console.WriteLine();
}
}
}}
//modificado