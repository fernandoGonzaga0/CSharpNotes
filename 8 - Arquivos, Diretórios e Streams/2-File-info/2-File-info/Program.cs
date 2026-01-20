/*

Existe no namespace System.IO sendo usada para obter informações detalhadas sobre um arquivo específico, como tamanho, nome, data de criação, data de modificação, etc.

Permite também realizar operações em um arquivo específico, como abrir, copiar, mover e excluir um arquivo.

Requer uma instância da classe para realizar as operações.

Quando as propriedades são recuperadas pela primeira vez, FileInfo chama o método Refresh e armazena em cache informações sobre o arquivo. 
Em chamadas subsequentes, você deve chamar Refresh para obter a cópia mais recente das informações. 

FileInfo - Métodos

    CopyTo - Copia um arquivo existente para um novo arquivo, não permitindo a substituição de um arquivo existente.
    Decrypt - Descriptografa um arquivo que foi criptografado pela conta atual usando o método Encrypt.
    Delete - Exclui o arquivo especificado.
    Crypt - Criptografa um arquivo para que apenas a conta usada para criptografar o arquivo possa descriptografá-lo.
    GetAccessControl - Obtém um objeto FileSecurity que encapsula as entradas da lista de controle de acesso (ACL) para um arquivo.
    MoveTo - Move um arquivo para um novo local, fornecendo a opção de especificar um novo nome de arquivo.
    Replace - Substitui o conteúdo de um arquivo definido pelo arquivo do objeto FileInfo atual, excluindo o arquivo original e criando um backup do arquivo substituído.
    ToString - Retorna um caminho como string
    Open - Abre um arquivo no FileMode especificado
    OpenRead - Cria um FileStream somente leitura
    OpenText - Cria um StreamReader com codificação UTF8 que lê um arquivo de texto existente.
    OpenWrite - Cria um FileStream somente para gravação.

*/

// obtendo o arquivo para análise
var caminhoOrigem = @"C:\dados\poesia.txt";

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine("\nNome do arquivo: " + arquivoOrigem.Name +
                    "\nCaminho do arquivo: " + arquivoOrigem.FullName +
                    "\nO arquivo é somente leitura? " + arquivoOrigem.IsReadOnly);