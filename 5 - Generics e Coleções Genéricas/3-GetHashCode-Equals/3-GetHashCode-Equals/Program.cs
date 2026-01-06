// GetHashCode e Equals são métodos da classe Object usados para comparar se dois objetos são iguais.

// Todos objetos na linguagem C# herdam de Object e assim herdam os métodos GetHashCde e Equals.

// GetHashCode retorna um valor inteiro (código hash, equivalente a um espaço localizado na memória) | Equals retorna um booleano

// Equals -> determina se duas instâncias de um objeto são iguais. Se compararmos dois objetos, retornará sempre falso.
string a = "José";
string b = "José";
var pessoa1 = new Pessoa("Fernando");
var pessoa2 = new Pessoa("Fernando");

Console.WriteLine(a.Equals(b));   // comparando instâncias do objeto string -> true
Console.WriteLine(pessoa1.Equals(pessoa2)); // comparando objetos diferentes -> false

// GetHasCode -> retorna um valor inteiro com base nas informações do objeto. É bem mais rápido que o método Equals. 

string c = "Pedro";
string d = "Pedro";
var animal1 = new Pessoa("Macaco");
var animal2 = new Pessoa("Macaco");

// calculando o gethashcode das variáveis e objetos
Console.WriteLine(c.GetHashCode());
Console.WriteLine(d.GetHashCode());
Console.WriteLine(animal1.GetHashCode());
Console.WriteLine(animal2.GetHashCode());

public class Pessoa
{
    public string Nome;
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}

public class Animal
{
    public string Nome;
    public Animal(string nome)
    {
        Nome = nome;
    }
}