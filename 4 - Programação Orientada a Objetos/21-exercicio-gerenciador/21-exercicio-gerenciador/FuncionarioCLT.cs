namespace _21_exercicio_gerenciador;
internal class FuncionarioCLT : Funcionario
{
    internal override decimal SalarioFinal()
    {
        return SalarioBase + ((SalarioBase*3) / 100);
    }
    internal FuncionarioCLT(string nome, int idade, long cpf, decimal salarioBase, string cargo) : base(nome, idade, cpf, salarioBase, cargo) { }
}