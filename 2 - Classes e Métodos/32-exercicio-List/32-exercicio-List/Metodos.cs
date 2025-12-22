using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _32_exercicio_List;

namespace _32_exercicio_List
{
    public class Metodos
    {
        // método para exibir a lista de alunos
        public static void ExibeAlunos()
        {
            // List<Aluno> alunosExibir = Aluno.alunos;
            foreach (Aluno aluno in Aluno.alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
            } 
        }
    }
}
