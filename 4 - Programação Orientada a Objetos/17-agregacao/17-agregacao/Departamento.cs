using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agregacao;

internal class Departamento
{
    public Departamento (string nome) // construtor da classe, obrigando que quando a classe seja criada, o user insira também o nome do departamento
    {
        Nome = nome;
        Professores = new List<Professor> ();
    }

    public string? Nome { get; set; }
    public List<Professor> Professores { get; set; } // A List<Professor> é uma coleção de referências para objetos da classe Professor.

    public void AdicionarProfessor(Professor professor)
    {
        Professores.Add (professor);
    }
    public void ListarProfessores()
    {
        Console.WriteLine($"Departamento: {Nome}");
        foreach (var prof in Professores)
        {
            prof.ExibirDados();
        }
    }

}