// TABUADA DE NÚMERO N COM CONTADOR

using System;

class Program
{
    static void Main()
    {
        string entrada;
        double numeroEntradaConvertido;
        int contador = 1;

        Console.WriteLine("Digite um número maior que zero: ");
        entrada = Console.ReadLine(); // faremos a conversão pelo TryParse 

        bool confirmacaoEntrada = double.TryParse(entrada, out numeroEntradaConvertido);

        while (confirmacaoEntrada == false)
        {
            Console.WriteLine("Insira um número válido maior que zero!");
            entrada = Console.ReadLine();
            confirmacaoEntrada = double.TryParse(entrada, out numeroEntradaConvertido);
        }

        Console.WriteLine($"Tabuada do número {numeroEntradaConvertido} até 10.\n");

        while (contador < 11)
        {
            Console.WriteLine($"{numeroEntradaConvertido} x {contador} = {numeroEntradaConvertido * contador}\n");
            contador++;
        }

        Console.WriteLine("Fim do processamento...");
    }
}