using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_consultas;

public class FonteDados
{
    public static List<int> GetNumeros()
    {
        List<int> numeros = new List<int>()
        {
            1, 2, 4, 8, 16, 32, 64, 28, 256, 512
        };
        return numeros;
    }

    public static List<int> GetListaNegra()
    {
        List<int> numeros = new List<int>()
        {
            16, 128, 512
        };
        return numeros;
    }

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Nome = "Fernando", Idade = 42},
            new Aluno() { Nome = "Maria", Idade = 32},
            new Aluno() { Nome = "Julio", Idade = 19},
            new Aluno() { Nome = "Sara", Idade = 22},
        };
        return alunos;
    }
}