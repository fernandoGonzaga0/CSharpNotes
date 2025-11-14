/*

Os contrutores são tipos especiais de métodos usados para criar e inicializar objetos de uma classe.
 
Na linguagem C# toda a classe precisa de um construtor para ser instanciada (caso não seja criado, o C# possui um construtor padrão para a classe)

Sempre que uma classe for instanciada usando a palavra new, o seu construtor é chamado. 

OBS: 
    i - um construtor deve possuir o mesmo nome da classe;
    ii - não possui nenhum tipo de retorno (nem mesmo void);
    III - pode possuir parâmetros que são usados para inicializar os membros da classe;

Ex de construtor padrão: 

    public class Aluno;
        
    {
        public Aluno();      <---- esse é o construtor, com mesmo nome da classe e sem retorno (quando passado sem parâmetros, serão atribuidos valores padrão -> int = 0; string = null; double = 0...)

        public string Nome;
        public int Idade; 
        .... //
    }

    Aluno aluno1 = new Aluno() <--- quando criamos o objeto, o construtor padrão é chamado trazendo os valores estabelecidos na classe (se estiver vazio, traz valores padrão ^)
 
 */