namespace _21_exercicio_gerenciador
{
    internal class Funcionario
    {
        internal string? Nome { get; set; }
        internal int Idade { get; set; }
        internal long CPF { get; set; }
        internal decimal SalarioBase { get; set; }
        internal string? Cargo { get; set; }

        public Funcionario(string nome, int idade, long cpf, decimal salarioBase, string cargo)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            SalarioBase = salarioBase;
            Cargo = cargo;
        }

        internal virtual decimal SalarioFinal() // na classe base o método apenas retorna o valor de salário Base (usado em estágios | para outros cargos será feito um override)
        {
            return SalarioBase;
        }
        internal void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Salario: {SalarioFinal()}");
        } // método 
    }
}