/*

File -> está no namespace System.IO e é usada para realizar operações de leitura e gravação de arquivos.

Fornece métodos estáticos para criar, copiar, excluir, mover e abrir arquivos e também fornece métodos para trabalhar com diretórios, como criar/excluir/mover diretórios.

Métodos:  

1) Criação e manipulação de arquivos.

    create -> cria um novo arquivo.
    delete -> exclui um arquivo.
    exists -> verifica se um arquivo existe.
    copy   -> copia um arquivo existente para um novo arquivo.
    move   -> move um arquivo para um novo local permitindo fornecer um novo nome.

2) Leitura e escrita de arquivos.

    ReadAllText ->  abre o arquivo, lê todo o conteúdo de um arquivo e retorna uma string e fecha.
    ReadAllBytes -> lê todo o conteúdo de um arquivo binário e retorna um array de bytes.
    WriteAllText -> cria um novo arquivo e grava uma string em um arquivo de texto e fecha o arquivo.
    WriteAllBytes -> grava um array de bytes em um arquivo binário.
    AppendAllText -> abre o arquivo, anexa uma string e fecha o arquivo.

*/

string caminho1 = @"C:\dados\arquivo1.txt";
string caminho2 = @"C:\dados\arquivo2.txt";

// criando arquivo
// File.Create(caminho1);   <---- ARQUIVO JÁ CRIADO

// escrevendo texto em arquivo
File.WriteAllText(caminho2, "Autor: Fernando Gonzaga.");

string novoTexto = "\nO poeta é um fingidor" +
    Environment.NewLine +
    "Finge tão completamente\r\n" +
    "Que chega a fingir que é dor\r\n" +
    "A dor que deveras sente.\r\n";

// Adicionando texto à um arquivo existente
File.AppendAllText(caminho2,  novoTexto);

// lendo o conteúdo do arquivo
Console.WriteLine("\nConteúdo e informações do arquivo: \n");
string conteudoCaminho2 = File.ReadAllText(caminho2);
Console.WriteLine(conteudoCaminho2);

Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTime(caminho2)}"); // File é uma classe e seus métodos são estáticos, posso invocá-los aqui diretamente.
Console.WriteLine($"Último acesso feito em: {File.GetLastWriteTime(caminho2)}\n");

// outra forma de ler o conteúdo do arquivo
string[] linhas = File.ReadAllLines(caminho2);
foreach(var linha in linhas)
{
    Console.WriteLine(linha);
}

// copiando arquivos
var caminhoCopia = @"C:\dados\arquivo2_copia.txt";
Console.WriteLine($"\nCopiando de {caminho2} para {caminhoCopia}");
File.Copy(caminho2, caminhoCopia);


Console.ReadKey();