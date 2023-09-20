
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
    

            DadosPessoa pess = new DadosPessoa();

            pess.entradaDadosPessoa ();
            
        }
    }
}
