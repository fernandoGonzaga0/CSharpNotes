/*
 
Crie um programa Console que, usando a classe HttpClient, acesse um arquivo na internet.

Verifique se o acesso foi feito com sucesso e lance a exceção HttpRequestException caso ocorra uma exceção.

Realize o tratamento de exceções considerando as exceções relacionadas ao código de status (StatusCode) HTTP: 400 (Bad request), 401 (Unauthorized), 404 (Not Found) e 500 (internal server error) usando o filtro de exceções.

Dados: Url do servidor -> https://marcoratti.net/dados 
       Nome do arquivo -> poesia.txt

*/

try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://marcoratti.net/dados\n");
    Console.WriteLine("Informe o nome do arquivo:");
    string? arquivo = Console.ReadLine();
    Console.WriteLine("Informe a url do site:");
    string? url = Console.ReadLine();
    Console.WriteLine("\nAguarde...");

    HttpClient client1 = new HttpClient(); // classe própria do HttpClient
    HttpResponseMessage response = client1.GetAsync(url + arquivo).Result; // classe própria de resposta de Http

    if (response.IsSuccessStatusCode) // método de verificação se o retorno do request foi feito com sucesso (retorna bool)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso:");
        Console.WriteLine("Código de status: " + response.StatusCode);
    }
    else
    {
        throw new HttpRequestException("Erro: " + (int)response.StatusCode);
    }
}

catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada!");
}

catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado!");
}

catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida!");
}

catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor!");
}

catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}

finally
{
    Console.WriteLine("Processamento concluído...");
}