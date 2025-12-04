using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_operadores_projecao
{
    internal class Funcionarios
    {        
        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new()
            {
                new Funcionario() { Nome = "André", Idade = 22, Salario = 4300m},
                new Funcionario() { Nome = "Lucio", Idade = 26, Salario = 6980m},
                new Funcionario() { Nome = "Julia", Idade = 32, Salario = 2400m},
                new Funcionario() { Nome = "Sara", Idade = 42, Salario = 12000m},
                new Funcionario() { Nome = "Savio", Idade = 32, Salario = 42000m},
            };
            return funcionarios;
        }
        public class Funcionario
        {
            public string? Nome { get; set; }
            public int Idade { get; set; }
            public decimal Salario { get; set; }
        }
    }
}