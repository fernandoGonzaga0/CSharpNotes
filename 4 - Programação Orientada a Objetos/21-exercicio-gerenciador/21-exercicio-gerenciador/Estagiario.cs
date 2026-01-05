namespace _21_exercicio_gerenciador;

internal class Estagiario : Funcionario
{
    int MatriculaFaculdade { get; set; }

    internal Estagiario(string nome, int idade, long cpf, decimal salarioBase, string cargo) : base(nome, idade, cpf, salarioBase, cargo) { }
}