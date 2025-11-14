using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_agregacao;

internal class Professor
{
    public Professor(string? nome, string? disciplina) // construtor da classe, obrigando que quando a classe seja criada, o user insira também o nome e a disciplina do professor
    {
        Nome = nome;
        Disciplina = disciplina;
    }

    public string? Nome { get; set; }

    public string? Disciplina {  get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Professor: {Nome}, Disciplina: {Disciplina}");
    }

}
