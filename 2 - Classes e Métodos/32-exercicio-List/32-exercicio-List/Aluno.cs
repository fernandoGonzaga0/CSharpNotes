using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_exercicio_List
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public double Nota { get; set; }

        // lista criada com public static para permitir a referênciação em outra classe no namespace
        public static List<Aluno> alunos = new()
        {
            new Aluno { Nome = "Maria", Nota = 8.74},
            new Aluno { Nome = "Manoel", Nota = 6.95},
            new Aluno { Nome = "Amanda", Nota = 7.25 },
            new Aluno { Nome = "Carlos", Nota = 6.55},
            new Aluno { Nome = "Jaime", Nota = 8.50},
            new Aluno { Nome = "Debora", Nota = 5.95},
            new Aluno { Nome = "Alicia", Nota = 9.25},
            new Aluno { Nome = "Sandra", Nota = 5.55},
            new Aluno { Nome = "Marta", Nota = 7.85},
            new Aluno { Nome = "Sueli", Nota = 9.15}
        };
    }
}