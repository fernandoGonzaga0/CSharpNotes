namespace FuncionarioNamespace // isso habilitará a comunicação da classe entre os arquivos
{
    public partial class Funcionario
    {
        public double Salario;
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\nSalário: {Salario}"); // Nome e Dados 
        }
    }
}
