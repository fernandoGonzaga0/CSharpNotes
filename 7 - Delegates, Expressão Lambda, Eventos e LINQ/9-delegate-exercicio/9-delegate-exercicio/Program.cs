/*
 
Considere que você esteja desenvolvendo um sistema que gerencia uma lista de pessoas. Cada pessoa possui um nome e uma idade. Para implementar algumas funcionalidades desse sistema, você precisará utilizar delegates. Siga as instruções abaixo para decidir qual delegate utiilzar em cada caso:

1) Você precisa percorrer a lista de pessoas e imprimir o nome e idade de cada uma. Qual delegate utilizar? 

2) Você precisa filtrar a lista de pessoas, retornando apenas aquelas que possuem idade maior do que 18 anos. Qual delegate usar?
 
3) Você precisa obter o nome e idade da pessoa mais velha da lista. Qual delegate utiilzar?

Dados: 

    Classe Pessoa com duas propriedades -> Nome e Idade.
    Lista de Pessoas: João-20, Maria-18, Pedro-25, Carlos-15, Ana-17
 
*/
using System;

public class Pessoa
{
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public string? Nome { get; set; }
    public int Idade { get; set; }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("----- MENU PESSOAS -----\n");

        List<Pessoa> ListaPessoa = new List<Pessoa>
        {
            new Pessoa("João", 20),
            new Pessoa("Maria", 18),
            new Pessoa("Pedro", 25),
            new Pessoa("Carlos", 15),
            new Pessoa("Ana", 17),
        };

        // 1) Percorrendo a lista de pessoas e imprimindo cada uma delas
        Action<Pessoa> ImprimePessoa = pessoa => // pessoa aqui é um parâmetro temporário (lambda) que representa um objeto do tipo Pessoa
        {
            Console.WriteLine($"\nNome: {pessoa.Nome}, Idade: {pessoa.Idade}");
        };
        Console.WriteLine("Pessoas)");
        ListaPessoa.ForEach(ImprimePessoa); // para cada pessoa na lista será chamado o delegate action ImprimePessoa

        // 2) Filtrando a lista de pessoas, retornando apenas aquelas que possuem idade maior do que 18 anos
        Action<Pessoa> ImprimeMaiorDeIdade = maiorDeIdade =>
        {
            if (maiorDeIdade.Idade >= 18)
            {
                Console.WriteLine($"\n{maiorDeIdade.Nome} possui {maiorDeIdade.Idade} anos.");
            }
        };

        Console.WriteLine("\nPessoas maiores de 18 anos)");
        ListaPessoa.ForEach(ImprimeMaiorDeIdade);

        // 3) Obter o nome e a idade da pessoa mais velha da lista
        Func<Pessoa, int> idadeMaisAntiga = p => p.Idade;
        int idadeMaxima = ListaPessoa.Max(idadeMaisAntiga); // idadeMaxima recebe a lista de pessoas com método Max (maior numero) usando a Func idadeMaisAntiga como base, que retorna cada idade
        Console.WriteLine("\nPessoa mais velha: )");
        var pessoaMaisVelha = ListaPessoa.Find(p => p.Idade == idadeMaxima);
        Console.WriteLine($"\nA pessoa mais velha é: {pessoaMaisVelha.Nome} com {pessoaMaisVelha.Idade} anos.");

    }
}