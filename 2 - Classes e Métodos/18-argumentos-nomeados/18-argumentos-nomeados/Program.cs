/*
 
ARGUMENTOS NOMEADOS

Permitem que você especifique um argumento para um parâmetro correspondendo o argumento com seu nome em vez de com sua posição na lista de parâmetros.
                   
*/

public class Email
{
    public void Enviar(string email, string password, string assunto)
    {
        Console.WriteLine($"Para {email}, senha {password}, assunto: {assunto}.\n");
    }

    public static void Main()
    {
        // forma PADRÃO de chamada do método -> observando que a ordem dos parâmetros até então deve ser respeitada, senão o método fará a impressão em ordem incorreta
        Email primeiroEnvio = new();
        primeiroEnvio.Enviar("fernando@gmail.com", "1234", "Primeiro envio de email!");

        // forma ARGUMENTO NOMEADO -> utilizaremos o parametro + : para referenciar o parâmetro diretamente pelo nome, independente da ordem que o método espera
        Email segundoEnvio = new();
        segundoEnvio.Enviar(password: "44444", assunto: "Email aleatório...", email: "fernandooliv21@gmail.com");
    }
}