public class Aluno // classe aluno
{
    public Aluno(string nome, int idade, string sexo)  //   <--- construtor padrão com 3 parâmetros
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }

    public string? Nome;   // 3 componentes utilizados na classe
    public int Idade;
    public string? Sexo;
}

class Program
{
    public void Main()
    {
        // agora quando eu instanciar a classe Aluno, o objeto deverá possuir os valores para preenchimento dos parâmetros que inserimos na linha 3)
        Aluno aluno1 = new("Fernando", 25, "Masculino"); 
    }
}