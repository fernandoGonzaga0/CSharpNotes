/*

Um relacionamento de agregação é um tipo especial de composição onde objetos de uma classe podem conter um ou mais objetos de outra classe.

A diferença é que aqui, a classe pai independe das classes filhas, onde sua existência não é vital para as classes derivadas. 

-> A PARTE PODE EXISTIR SEM O TODO

Ex: supondo que tenha uma classe Professor e outra classe Departamento (no momento, departamento é o todo). Nesse cenário, a classe Professor não depende
de Departamento para existir, mas métodos e propriedades de Professor são usados em Departamento para construir algo.

-> Um Departamento pode ter vários Professores, mas os Professores podem existir fora do Departamento. Isso é agregação.

 */

namespace _17_agregacao;

class Program
{
    static void Main()
    {
        // Criando professores
        Professor prof1 = new Professor("Carlos", "Matemática");
        Professor prof2 = new Professor("Joice", "Física");
        Professor prof3 = new Professor("Beatriz", "Português");

        // Criando departamentos
        Departamento dep1 = new Departamento("Ciências Exatas");
        Departamento dep2 = new Departamento("Ciências Humanas");

        // Inserindo professores em seus respectivos departamentos
        dep1.AdicionarProfessor(prof1);
        dep1.AdicionarProfessor(prof2);
        dep2.AdicionarProfessor(prof3);

        // Exibindo os departamentos.
        dep1.ListarProfessores();
        dep2.ListarProfessores();
    }
}
