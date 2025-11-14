/*
 
Um construtor estático é usado para inicializar quaisquer membros estáticos ou para executar uma ação específica que precisa ser executada apenas uma vez. 
Ele é chamado automaticamente antes que a primeira instânca seja criada ou que quaisquer membros estáticos sejam referenciados.
Não aceita parâmetros, não aceita ser chamado diretamente e só existe um por classe.

*/

using System;

class Configuracao
{
    public static string? Ambiente; // componente estático

    static Configuracao() // <---- construtor estático
    {
        Console.WriteLine("Inicialzando configurações..."); // essas duas linhas do construtor serão executadas sem qualquer chamado, antes do primeiro uso da classe
        Ambiente = "Produção";
    }

    public static void MostrarAmbiente()
    {
        Console.WriteLine($"Ambiente atual: {Ambiente}");
        Console.ReadKey(); // serve para segurar o console aberto já que ele apenas executa e termina o código
    }
}

class Program
{
    static void Main()
    {
        Configuracao.MostrarAmbiente(); // aqui estou chamando apenas o segundo método, mas repare que o primeiro método (construtor estático) é executado antes automaticamente
    }
}