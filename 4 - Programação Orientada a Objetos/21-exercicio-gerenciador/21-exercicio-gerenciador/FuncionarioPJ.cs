namespace _21_exercicio_gerenciador;
internal class FuncionarioPJ : Funcionario
{
    internal long CNPJ { get; set; }
    internal override decimal SalarioFinal()
    {
        return SalarioBase + ((SalarioBase*7) / 100);
    }
    internal FuncionarioPJ(string nome, int idade, long cpf, decimal salarioBase, string cargo, long CNPJ) : base(nome, idade, cpf, salarioBase, cargo) { }
}