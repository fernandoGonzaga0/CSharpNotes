/*
 
Parâmetros são passados em métodos como variáveis dentro do próprio método.

Exemplo abaixo.
  
*/

class Program
{
    static void InsereSobrenome(string primeiroNome) // o método InsereSobrenome espera previamente a string contendo o primeiro nome do usuário
    {
        Console.WriteLine(primeiroNome + " Gonzaga\n");
    }

    static void CadastroCliente(string firstName, string lastName, int age, string address, int phone)
    {
        Console.WriteLine
            ($"Nome: {firstName + " " + lastName}\n" +
            $"Idade: {age}\n" +
            $"Endereço: {address}\n" +
            $"Telefone: {phone}\n");
    }

    static void Main()
    {
        Console.WriteLine("Método de inserção de sobrenomes:\n");
        InsereSobrenome("Fernando");
        InsereSobrenome("Pedro");

        Console.WriteLine("Método de cadastro de usuários:\n");
        CadastroCliente("Fernando", "Gonzaga", 25, "Rua das Tulipas, Q12, L 252", 992873378);
    }
}