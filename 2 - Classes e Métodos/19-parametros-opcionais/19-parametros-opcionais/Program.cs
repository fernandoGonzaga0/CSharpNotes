// Parâmetros opcionais devem ser inseridos no final do método e com um valor padrão. Caso não sejam utilizados, os valores padrão serão atribuídos.

public class Email
{
    public void Enviar(string email, string assunto, string observacoes = "Observação padrão.") // nesse cenário estabelecemos uma não obrigatoriedade para observações
    {
        Console.WriteLine($"Email: {email}\nAssunto: {assunto}\nObservações: {observacoes}");
    }

    public static void Main()
    {
        Email envio1 = new();
        envio1.Enviar("fernando@gmail.com", "Reunião de negócios"); // não foi necessário inserir a string de observações
    }
}