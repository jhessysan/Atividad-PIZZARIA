using System;

public class Pagamento
{
    // Método para pagamento com cartão de crédito
    public static void PagarComCartaoCredito(string nomeDoCliente)
    {
        // Lógica de processamento do pagamento com cartão de crédito
        Console.WriteLine();
        Console.WriteLine($"{nomeDoCliente}.");
        Console.WriteLine("VALOR RECEBIDO COM SUCESSO!");
        Console.WriteLine("Pagamento com cartão de crédito concluído!");
        return;
    }

    // Método para pagamento em dinheiro
    public static void PagarEmDinheiro(string nomeDoCliente)
    {    
        Console.WriteLine($"{nomeDoCliente}.");
        Console.WriteLine("Recebendo pagamento em dinheiro...");
        Console.WriteLine("Pagamento em dinheiro recebido!");
    }

    // Método para pagamento com cartão de alimentação
    public static void PagarComCartaoAlimentacao(string nomeDoCliente)
    {
        // Lógica de processamento do pagamento com cartão de alimentação
        Console.WriteLine($"{nomeDoCliente}.");
        Console.WriteLine("Processando pagamento com cartão de alimentação...");
        Console.WriteLine("Pagamento com cartão de alimentação concluído!");
    }
    public static double Soma(double a , double b)
    {
        var soma = a + b;
        return soma;
    }
}