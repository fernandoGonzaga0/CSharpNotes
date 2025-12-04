/*

Projeção -> é o mecanismo usado para selecionar os dados de uma fonte de dados. 

    i) selecionar todos os dados no estado original;
    ii) criar um novo formato de dados realizando operações nos dados originais;

Temos dois métodos usados para projeção:

    i) Select -> permite especificar quais propriedades queremos recuperar: todas as propriedades ou apenas algumas das propriedades.
                 a LINQ por padrão possui consulta adiada (só é feita de fato quando requisitamos a exibição dos dados), com o Select essa consulta é forçada e feita imediatamente.
                 métodos usados: ToList(), ToArray(), AsEnumerable, AsQueryable, ToDictionary(), ToLookUp()

    ii) SelectMany;

*/

using _3_operadores_projecao;

Console.WriteLine("----- LINQ | Operadores de Projeção -----\n");

// SELECT
var funcionariosComSalarioAnual = Funcionarios.GetFuncionarios().Select(f => new      // esse seletor cria variáveis anônimas para realização de consulta de dados
                                                                        {
                                                                            NomeFuncionario = f.Nome,
                                                                            IdadeFuncionario = f.Idade,
                                                                            SalarioAnual = f.Salario * 12
                                                                        }).ToList();

Console.WriteLine("Tabela de funcionários com salário anual: ");
foreach(var funcionario in funcionariosComSalarioAnual)
{
    Console.WriteLine($"{funcionario.NomeFuncionario} -> Idade: {funcionario.IdadeFuncionario} anos, Salário: {funcionario.SalarioAnual.ToString("c")} reais.");
}

Console.ReadKey();

// SELECTMANY