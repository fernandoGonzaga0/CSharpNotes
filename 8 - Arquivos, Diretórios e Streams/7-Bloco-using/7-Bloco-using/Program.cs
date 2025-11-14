// Lendo dados de um arquivo com bloco using

string caminhoArquivo = @"C:\dados\arquivo2.txt";

try
{
    using (FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read)) {
        using (StreamReader leitor = new StreamReader(fs))
        {
            string? linha;
            while ((linha = leitor.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        } // assim que conclui o modo using, o arquivo é fechado automaticamente
    }
}

catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();