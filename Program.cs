
using System;


namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           //Instanciar (criando objeto)

            Pizza piz = new Pizza();

            piz.entradaDados ();
    

             CadastroPessoa cadas = new CadastroPessoa();

            var dadosPessoa = cadas.CadastrarUmaPessoa();

            Console.WriteLine(dadosPessoa);

        }
    }
}
