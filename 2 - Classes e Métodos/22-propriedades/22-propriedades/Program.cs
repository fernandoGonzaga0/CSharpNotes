/*

As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores, enquanto oculta o código de implementação ou verificação.
 
Propriedades são membros de uma classe que funcionam como interfaces para acessar e modificar dados privados, com a vantagem de permitir controle, validação
e encapsulamento. 

São utilizadas para evitar que os componentes sejam criados sem nenhuma restrição.

public string? Nome; por exemplo, pode ser acessada a qualquer momento e ter dados atribuídos sem nenhuma condição prévia.

Usam os métodos acessadores get e set para ler e escrever valores.

Ex: código abaixo exemplifica a utilização em um banco protegendo o componente salário dos funcionários.
 
*/

class Funcionario
{
    private double salario; // campo
    public double Salario // propriedade (S maiúsculo)
    {
        get // permite ler o valor do campo (fazendo Funcionario.Salario ele retornará o valor armazenado aqui
        {
            return salario;
        }
        set // permite escrever um novo valor, com validação (entre 0 e 50000, nesse caso)
        {
            if (value >= 0 && value <= 50000)
            {
                salario = value;
            }
            else
            {
                Console.WriteLine("Valor de salário inválido!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Funcionario func1 = new();

        func1.Salario = 3900;  // válido
        Console.WriteLine("Salário atual: " + func1.Salario);

        func1.Salario = -800;  // inválido
        Console.WriteLine("Salário atual: " + func1.Salario);

        func1.Salario = 100560; // inválido
        Console.WriteLine("Salário atual: " + func1.Salario);
    }
}