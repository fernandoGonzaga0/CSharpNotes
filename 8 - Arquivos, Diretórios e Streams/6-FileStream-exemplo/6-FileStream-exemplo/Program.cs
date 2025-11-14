// Obtendo os dados do arquivo2 usando FileStream e StreamReader

string caminhoArquivo = @"C:\dados\arquivo2.txt";

FileStream fs = null;
StreamReader leitor = null;

try
{
    fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read); // obtendo o caminho do arquivo
    leitor = new StreamReader(fs);  // lendo o arquivo

    string? linha;
    while((linha = leitor.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}

catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    // garantindo que tanto o leitor quando o caminho do arquivo sejam fechados
    if (leitor != null) leitor.Close();
    if (fs != null) fs.Close();
}