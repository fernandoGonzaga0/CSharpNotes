/*

Existe no namespace System.IO sendo usada para obter informações detalhadas sobre um arquivo específico, como tamanho, nome, data de criação, data de modificação, etc.

Permite também realizar operações em um arquivo específico, como abrir, copiar, mover e excluir um arquivo.

Requer uma instância da classe para realizar as operações.

Quando as propriedades são recuperadas pela primeira vez, FileInfo chama o método Refresh e armazena em cache informações sobre o arquivo. Em chamadas subsequentes, você deve chamar Refresh para obter a cópia mais recente das informações. 

*/

// obtendo o arquivo para análise
var caminhoOrigem = @"C:\dados\poesia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: " + arquivoOrigem.Name +
                    "\nCaminho do arquivo: " + arquivoOrigem.FullName +
                    "\nO arquivo é somente leitura? " + arquivoOrigem.IsReadOnly);