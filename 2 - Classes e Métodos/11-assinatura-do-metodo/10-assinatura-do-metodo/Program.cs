/*
 
A sobrecarga de métodos acontece quando temos diversos métodos com mesmo nome, porém se diferenciando em número de parâmetros, tipos, ordem dos parâmetros, etc).

Ex: criarei uma classe com diversos métodos com mesmo nome, porém com suas características diferentes
 
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
