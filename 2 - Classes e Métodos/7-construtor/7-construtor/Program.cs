/*

Os contrutores são tipos especiais de métodos usados para criar e inicializar objetos de uma classe.

Na linguagem C# toda a classe precisa de um construtor para ser instanciada (caso não seja criado, o C# possui um construtor padrão para a classe)

Sempre que uma classe for instanciada usando a palavra new, o seu construtor é chamado. 

OBS: 
    i - um construtor deve possuir o mesmo nome da classe;
    ii - não possui nenhum tipo de retorno (nem mesmo void);
    III - pode possuir parâmetros que são usados para inicializar os membros da classe;

Ex de construtor padrão: 

*/

public class Aluno
{
    public Aluno() { } // construtor padrão vazio (não há necessidade de inserir essa linha, esse já é o comportamento padrão do construtor
    public string Nome;
    public int Idade;
}

public class Program
{
    public static void Main()
    {
        Aluno aluno = new Aluno();
    }
}