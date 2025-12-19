/*

A assinatura de um método é uma identificação exclusiva de um método para o compilador C#.
 
A sobrecarga de métodos acontece quando temos diversos métodos com mesmo nome, porém se diferenciando em número de parâmetros, tipos, ordem dos parâmetros, etc).

O tipo de retorno de um método não faz parte da assinatura do método.

Ex: criarei uma classe com diversos métodos com mesmo nome, porém com assinaturas diferentes (número/tipo/ordem de parâmetros diferentes)

*/

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine($"Endereço: {endereco}");
    }

    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Assunto: {assunto}");
    }

    public void Enviar (string assunto, string endereco, int addressNumber)
    {
        Console.WriteLine($"Endereço: {endereco}");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Número do endereço: {addressNumber}");
    }
}