/*

As classes Directory e DirectoryInfo são usadas para manipular diretórios em C# e ambas permitem a criação, exclusão e cópia, movimentação e renomeação de diretórios. 

A classe Directory é uma classe estática que fornece métodos estáticos para trabalhar com diretórios. 

| Método                          | Directory (Estático) | DirectoryInfo (Instância) | Descrição                                                                 |
|----------------------------------|-----------------------|----------------------------|---------------------------------------------------------------------------|
| `CreateDirectory()`              | ✅                    | ✅                         | Cria um novo diretório.                                                  |
| `Delete()`                       | ✅                    | ✅                         | Exclui o diretório especificado.                                         |
| `Exists()`                       | ✅                    | ✅                         | Verifica se o diretório existe.                                          |
| `GetFiles()`                     | ✅                    | ✅                         | Retorna os arquivos contidos no diretório.                               |
| `GetDirectories()`               | ✅                    | ✅                         | Retorna os subdiretórios contidos no diretório.                          |
| `GetCreationTime()`              | ✅                    | ✅                         | Retorna a data de criação do diretório.                                  |
| `GetLastAccessTime()`            | ✅                    | ✅                         | Retorna a data do último acesso ao diretório.                            |
| `GetLastWriteTime()`             | ✅                    | ✅                         | Retorna a data da última modificação no diretório.                       |
| `Move()`                         | ✅                    | ❌                         | Move um diretório para outro local.                                      |
| `EnumerateFiles()`               | ✅                    | ✅                         | Retorna uma enumeração dos arquivos no diretório.                        |
| `EnumerateDirectories()`         | ✅                    | ✅                         | Retorna uma enumeração dos subdiretórios.                                |
| `EnumerateFileSystemEntries()`   | ✅                    | ✅                         | Retorna arquivos e diretórios como uma enumeração.                       |
| `GetParent()`                    | ✅                    | ❌                         | Retorna o diretório pai de um caminho especificado.                      |
| `GetCurrentDirectory()`          | ✅                    | ❌                         | Retorna o diretório atual de trabalho.                                   |
| `SetCurrentDirectory()`          | ✅                    | ❌                         | Define o diretório atual de trabalho.                                    |
| `GetLogicalDrives()`             | ✅                    | ❌                         | Retorna os drives lógicos disponíveis no sistema.                        |
| `ToString()`                     | ❌                    | ✅                         | Retorna o caminho do diretório como string.                              |
| `Refresh()`                      | ❌                    | ✅                         | Atualiza o estado do objeto `DirectoryInfo`.                             |
| `Root` (propriedade)             | ❌                    | ✅                         | Retorna o diretório raiz do caminho.                                     |
| `Parent` (propriedade)           | ❌                    | ✅                         | Retorna o diretório pai como `DirectoryInfo`.                            |
 
*/

// é indicado sempre validar, antes de criar um diretório, se ele já existe. É ideal também fazer uma tratativa de excessão prévia. 

// criando um diretório
var caminhoDiretorio = @"C:\dados\MeuDiretorio";

Console.WriteLine("\nCriando um novo diretório: ");

// validando se o diretório realmente não existe
try
{
    if(!Directory.Exists(caminhoDiretorio)) // se o diretório não existir...
    {
        Directory.CreateDirectory(caminhoDiretorio); // cria um diretório
        Console.WriteLine($"Diretório {caminhoDiretorio} foi criado com sucesso!");
    }
    else
    {
        Console.WriteLine("O diretório já existe!");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();