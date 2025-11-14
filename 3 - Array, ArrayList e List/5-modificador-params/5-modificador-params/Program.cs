/*
 
Um problema para o cenário -> Criar um programa para calcular a soma de um número variável de números inteiros.
Resumo: criar um método que aceite um número ilimitado de argumentos.
 
 */

public class Calcular()
{
    public static int Soma(params int[] numeros) //params deve ser sempre o último componente de um método, até mesmo de componentes não obrigatórios
    {
        int total = 0;
        foreach (var numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}

class Program
{
    public static void Main()
    {
        //int[] valores = { 1, 6, 2, 5, 8, 4, 2, 6, 7, 3}; com o params, podemos inserir os valores diretamente na chamada
        var resultado = Calcular.Soma(1, 6, 2, 5, 8, 4, 2, 6, 7, 3);
        Console.WriteLine(resultado);
    }
}