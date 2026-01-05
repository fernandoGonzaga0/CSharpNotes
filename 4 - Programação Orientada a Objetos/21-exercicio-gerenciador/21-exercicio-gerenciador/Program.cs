/* 

Criando um sistema simples de gerenciamento de funcionários para uma empresa. 

A empresa possui diferentes tipos de funcionários, e cada um possui formas diferentes de calcular o salário.

*/

using _21_exercicio_gerenciador;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("---- Gerenciamento de Funcionários ----\n");

        Console.Write("\nCLTs:\n\n");

        // usando polimorfismo
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Estagiario("Bruno Fernandes", 21, 01125436114, 2500, "Estágio"),
            new Estagiario("Alice Bernardes", 23, 07124509821, 2500, "Estágio"),
            new Estagiario("Paulo Roberto", 19, 246012945891, 2500, "Estágio"),

            new FuncionarioCLT("Fernando Gonzaga", 25, 05125446114, 4500, "Desenvolvedor Jr"),
            new FuncionarioCLT("Ester Silva", 28, 10294381243, 4900, "Desenvolvedora Jr"),
            new FuncionarioCLT("Pedro Alcantara", 24, 45129438724, 5100, "Desenvolvedor Jr"),

            new FuncionarioPJ("Ana Laura", 32, 112009382891, 18000, "Desenvolvedora Pl", 22145512941812565),
            new FuncionarioPJ("Yuri Minamato", 29, 1245129501, 21400, "Desenvolvedor Sr", 204928102482790),
            new FuncionarioPJ("Elias Nascimento", 36, 220491827592, 25000, "Desenvolvedor Sr", 202492817295012)
        };

        // Exibindo estagiários
        Console.Write("Estagiários\n\n");
        List<Funcionario> estagiarios = funcionarios.Where(x => x.Cargo.Contains("Estágio", StringComparison.OrdinalIgnoreCase)).ToList();
        foreach (Funcionario estag in estagiarios)
        {
            estag.Exibir();
        }

        // Exibindo CLTs (por padrão, recebem até 10 mil nessa empresa)
        Console.WriteLine("\nCLTs\n\n");
        List<Funcionario> clts = funcionarios.Where(x => x.Cargo.Contains("Desenvol", StringComparison.OrdinalIgnoreCase) && x.SalarioBase < 10000).ToList();
        foreach (Funcionario cl in clts)
        {
            cl.Exibir();
        }

        // Exibindo PJs (salários acima de 10 mil)
        Console.WriteLine("\nPJs\n\n");
        List<Funcionario> pjs = funcionarios.Where(x => x.Cargo.Contains("Desenvol", StringComparison.OrdinalIgnoreCase) && x.SalarioBase > 10000).ToList();
        foreach (Funcionario pj in pjs)
        {
            pj.Exibir();
        }

        Console.ReadKey();
    }
}