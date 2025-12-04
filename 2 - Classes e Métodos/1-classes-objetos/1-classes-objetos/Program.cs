/*
                                                            CLASSES

Classes servem para criarmos modelos para criação de objetos.

Ex: a classe Pessoa cria um molde que utilizaremos para criar diversas pessoas (objetos)

                                                            oBJETOS

Um objeto é uma instância de uma classe, criado pelo operador new e todos os membros da classe (campos) podem ser acessados através do objeto 

*/

public class Pessoa // classe pública = pode ser acessada/instanciada por qualquer outra classe no projeto e também por classes em outros projetos por referência
{
    // atribuição de 3 campos/componentes
    public string? nome; // interrogação valida se a variável será nula ou não. Por uma string ser um tipo de referência, ela pode armazenar um null. Estamos avisando ao compilador que ela pode ser nula.
    public int idade;
    public string? sexo;
}

// OBS -> na classe acima foram usados duas vertentes da POO:

// abstração (por comprimirmos campos na classe como nome/idade/sexo, que são elementos reais de uma pessoa de fato);
// encapsulamento -> encapsulamos os campos abstratos na classe Pessoa;

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa(); // Pessoa p1 = new() também é válido
        p1.nome = "Fernando";
        p1.idade = 25;
        p1.sexo = "Masculino";

        Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");
    }
}