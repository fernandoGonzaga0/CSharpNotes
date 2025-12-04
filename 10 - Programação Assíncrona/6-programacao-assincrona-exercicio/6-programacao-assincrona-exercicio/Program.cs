/*
Realize o download de um arquivo da internet usando a classe HttpClient. Utilize a programação assícrona para que o programa não trave durante as operações de download. 
Trate as possíveis exceções que podem ocorrer durante o download. 
Para  o tratamento de exceções, o programa deve informar ao usuário sobre o erro.
Permita que a operação de download seja cancelada após um determinado período de tempo, e caso isso ocorra, o programa deve informar ao usuártio que a operação foi cancelada.
Ao final, o programa deve exibir na tela uma mensagem informando que o arquivo foi baixado com sucesso.
*/

static async Task ExecutaOperacaoAsync()
{
    // criar um CancellationTokenSource
    var tempo = 10;
    var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(tempo));

    Console.WriteLine("\nIniciando o download...");
    Console.WriteLine($"\nCancelando a operação após {tempo} segundos...");

    try
    {
        using var httpClient = new HttpClient();
        var destino = "C:\\dados\\arquivo.txt";

        var response = await httpClient.GetAsync("https://outlook.office.com/mail/0/?deeplink=mail%2F0%2F%3Fnlp%3D0", HttpCompletionOption.ResponseHeadersRead,cancellationTokenSource.Token);

        var totalBytes = response.Content.Headers.ContentLength;
        var readBytes = 0L;

        await using var fileStream = new FileStream(destino, FileMode.Create,
                                                    FileAccess.Write);
        await using var contentStream = await response.Content.ReadAsStreamAsync(cancellationTokenSource.Token);

        var buffer = new byte[81920];
        int bytesRead;

        while((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationTokenSource.Token))>0) 
        {
            await fileStream.WriteAsync(buffer,0, bytesRead, cancellationTokenSource.Token);
        }
    }
    catch (OperationCanceledException ex)
    {
        if (cancellationTokenSource.IsCancellationRequested)
        {
            Console.WriteLine("\nDownload cancelado pelo usuário: " + ex.Message);
        }
        else
        {
            Console.WriteLine("\nO tempo limite para o download foi atingido.");
        }
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"\nOcorreu um erro de rede: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nOcorreu um erro desconhecido: {ex.Message}");
    }
    finally 
    {
        Console.WriteLine("\nDownload finalizado!");
    }
}