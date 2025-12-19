/*
 
1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int.
Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”

a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto

d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.

e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
método Acelerar passando o valor do argumento para o parâmetro no método Acelerar

g- Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)

h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro

i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que vai retornar um double representando a velocidade máxima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)

j- Explique o comportamento da palavra return

l- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 3 ao parâmetro recebido)

*/

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Marca = marca;
        Ano = ano;
        Potencia = potencia;
    }

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public static void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o {marca}");
    }

    public static void Exibir(Carro carro)
    {
        Console.WriteLine($"{carro.Marca} -> Modelo: {carro.Modelo}, Montadora: {carro.Montadora}, Ano: {carro.Ano}, Potência: {carro.Potencia}");
    }

    public static double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public static int AumentarPotencia(int potencia) // por valor
    {
        return potencia * 3;
    }

    public static int AumentarPotencia(ref int potenciaRef)
    {
        potenciaRef = potenciaRef * 5;
        return potenciaRef;
    }
}

public class Program
{
    public static void Main()
    {
        Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
        Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

        Carro.Exibir(chevrolet);
        Carro.Acelerar(chevrolet.Marca);
        Console.WriteLine($"Potência do carro: " + Carro.VelocidadeMaxima(chevrolet.Potencia) + " W (p*1.75)");
        // passagem de argumento por valor
        Console.WriteLine($"Aumentando potência do carro: " + Carro.AumentarPotencia(chevrolet.Potencia) + " W (p*3)\n");
        // passagem de argumento por referência
        Console.WriteLine($"Aumentando a potência por referência: " + Carro.AumentarPotencia(chevrolet.Potencia));

        //Carro.Exibir(ford);
        //Carro.Acelerar(ford.Marca);
        //Console.WriteLine($"Potência do carro: " + Carro.VelocidadeMaxima(ford.Potencia) + " W (p*1.75)");
        //// passagem de argumento por valor, onde a potencia 
        //Console.WriteLine($"Aumentando potência do carro: " + Carro.AumentarPotencia(ford.Potencia) + " W (p*3)\n");

        Console.ReadKey();
    }
}