// CRIANDO MAIS DE UM CONSTRUTOR NA CLASSE

/*
OBS: relação entre os 4 componentes e os 2 construtores

A relação entre eles é de inicialização do estado -> 
*/

public class Aluno
{
    // 4 componentes -> são atributos que definem as características de um aluno; são variáveis públicas que podem ser acessadas de fora da classe
    public string? Nome;
    public string? Sexo;
    public int Idade;
    public string? Aprovado;

    // primeiro construtor -> não é obrigatório ter um construtor com o nome da classe caso exista(m) algum(s) construtor(es).
    public Aluno(string nome) // 
    {
        Nome = nome;
    }

    // segundo construtor -> por mais que possua o mesmo nome do primeiro construtor, o C# diferencia eles pela quantidade/tipo/ordem dos parâmetros
    public Aluno(int idade, string sexo, string aprovado)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    // resumo: os construtores são formas de dizer como certos dados devem ficar ->
    // construtor 1 aceita somente o nome como inserção padrão, deixando os outros dados nulos (é possível padronizar os dados, se necessário)
    // construtor 2 aceita sexo, idade e aprovado, mas deixa o nome com valor null (padrão)
}

class Program
{
    public void Main()
    {
        // chamando o primeiro construtor, que aceita apenas nome
        Aluno aluno1 = new("Fernando");

        // chamando o segundo construtor, que aceita idade, sexo e aprovado
        Aluno aluno2 = new(25, "Masculino", "Sim");
        
    }
}