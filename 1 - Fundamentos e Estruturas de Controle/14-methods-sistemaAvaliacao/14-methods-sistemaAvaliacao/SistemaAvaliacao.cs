using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_methods_sistemaAvaliacao;

class SistemaAvaliacao
{
    public static double CalcularMediaPonderada(double nota1, double peso1, double nota2, double peso2, double nota3, double peso3)
    {
        double mediaFinal = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3);
        return Math.Round(mediaFinal, 2);
    }

    // observar que o retorno da função double CalcularMediaPonderada é, de fato, um double
    // sua entrada (parametro) também está em double


    public static string ClassificarAluno(double media)
    {
        if (media >= 6)
        {
            return "Aprovado";
        }
        else if (media >= 3) // automaticamente menor que 6
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }

    // observar que o retorno da função string ClassificarAluno é, de fato, uma string
    // sua entrada (parametro) está em double


    public static void ExibirResultado(string nome, double media, string status)
    {
        Console.WriteLine("----- Relatório do Aluno -----");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine("------------------------------\n");
    }

}