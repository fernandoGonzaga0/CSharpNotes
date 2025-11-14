/*

Crie um programa que ofereça um menu de opções para manipulação de um arquivo texto utilizando as classes FileStream, StremReader e StreamWriter.

As opções devem ser: 

1) Criar arquivo -> permite criar um novo arquivo texto, caso ele não exista, ou sobrescrever um arquivo existente. 
2) Gravar no arquivo: permite adicionar conteúdo ao arquivo. O usuário deve poder digitar o conteúdo que deseja adicionar ao arquivo.
3) Ler arquivo: exibe o conteúdo completo do arquivo na tela.
4) Procurar no arquivo: permite procurar um texto no arquivo e exibir a posição da primeira ocorrência na tela. O usuário deve poder digitar o texto a ser procurado.
 
*/

string caminhoArquivo = @"C:\dados\ExercicioStreams\exercicio.txt";

Console.WriteLine("\nCaminho do arquivo a ser criado: ");
Console.WriteLine(caminhoArquivo);

while(true)
{
    Console.WriteLine("\nSeleciona uma opção: ");
    Console.WriteLine("1 - Criar arquivo.");
    Console.WriteLine("2 - Gravar um arquivo.");
    Console.WriteLine("3 - Ler arquivo.");
    Console.WriteLine("4 - Procurar texto em arquivo.");
    Console.WriteLine("0 - Sair.");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            return;
        case 1:
            CriarArquivo(caminhoArquivo);
            break;
        case 2:
            GravarArquivo(caminhoArquivo);
            break;
        case 3:
            LerArquivo(caminhoArquivo);
            break;
        case 4:
            ProcurarTexto(caminhoArquivo);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

static void CriarArquivo(string caminhoArquivo)
{
    if (File.Exists(caminhoArquivo)) {
        Console.WriteLine("O arquivo já existe!\nRetornando ao menu...");
    }
    try
    {
        using(FileStream fs = new FileStream(caminhoArquivo,   // usando a classe FileStream, estamos acessando o caminho e criando um arquivo com o bloco using
                                             FileMode.Create,
                                             FileAccess.Write))
        {
            Console.WriteLine($"\n>> Arquivo {caminhoArquivo} criado com sucesso!");
        }
    }
    catch (Exception ex) 
    {
        Console.WriteLine(ex.Message);
    }
}

static void GravarArquivo(string caminhoArquivo)
{
    Console.WriteLine("Digite o texto a ser gravado: ");
    string texto = Console.ReadLine(); // user insere o texto

    try
    {
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
        {
            writer.WriteLine(texto);  // texto é registrado em na Stream 'writer', 
        }
        Console.WriteLine($"\n>> Texto gravado com sucesso!");
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void LerArquivo(string caminhoArquivo)
{
    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine($">> Arquivo {caminhoArquivo} não encontrado!");
        return;
    }

    try
    {
        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            Console.WriteLine($"Texto do arquivo {caminhoArquivo}: ");
            string linha; 
            while((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void ProcurarTexto(string caminhoArquivo)
{
    if (!File.Exists(caminhoArquivo))
    {
        Console.WriteLine("O arquivo não existe!\nRetornando ao menu...");
    }

    Console.WriteLine("\nDiite o texto a ser procurado: ");
    string textoProcurado = Console.ReadLine();

    try
    {
        bool encontrado = false;

        using (StreamReader reader = new StreamReader(caminhoArquivo))
        {
            string linha;
            int numLinha = 0;
            while ((linha = reader.ReadLine()) != null)
            {
                numLinha++;
                if (linha.Contains(textoProcurado))
                {
                    Console.WriteLine($"\n>> Texto encontrado na linha {numLinha}: {linha}");
                    break;
                }
            }
        }
        if (!encontrado)
        {
            Console.WriteLine($"\n>> Texto {textoProcurado} não encontrado no arquivo {caminhoArquivo}.");
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine(ex.Message);
    }
}