/*

FileStream -> Fornece um stream para arquivo, dando suporte a operações de leitura e gravação síncronas e assíncronas. Esta classe deriva da classe Stream.  

Um Stream é uma sequência de dados (bytes) que pode ser lida ou escrita em partes menores. A classe Stream é a classe base para todos os streams. 

Ela pode ser usada para ler, gravar, abrir e fechar arquivos em um sistema de arquivos e para tratar com outros manipuladores do sistema operacional relacionados a arquivos, incluindo pipes (canais de comunicação entre processos), a entrada padrão e saída padrão.

Classes auxiliares -> StreamReader (fornece métodos para ler strings de um FileStream covertendo bytes em string;
                      StreamWrite (métodos para gravar strings em um FileStream convertendo bytes em string;

### 📄 Tabela de Propriedades da Classe `FileStream`

| Propriedade           | Tipo             | Somente Leitura | Descrição                                                                 |
|-----------------------|------------------|------------------|---------------------------------------------------------------------------|
| `CanRead`             | `bool`           | ✅               | Indica se o fluxo dá suporte à leitura.                                  |
| `CanWrite`            | `bool`           | ✅               | Indica se o fluxo dá suporte à gravação.                                 |
| `CanSeek`             | `bool`           | ✅               | Indica se é possível buscar (seek) uma posição no fluxo.                 |
| `Length`              | `long`           | ✅               | Obtém o comprimento do fluxo em bytes.                                   |
| `Position`            | `long`           | ❌               | Obtém ou define a posição atual no fluxo.                                |
| `Name`                | `string`         | ✅               | Retorna o caminho do arquivo associado ao `FileStream`.                  |
| `SafeFileHandle`      | `SafeFileHandle` | ✅               | Obtém o identificador seguro do arquivo.                                 |
| `IsAsync`             | `bool`           | ✅               | Indica se o `FileStream` foi aberto para operações assíncronas.          |
| `Handle` *(obsoleto)* | `IntPtr`         | ✅               | Representa o identificador do arquivo (não recomendado em código novo).  |

### 📄 Tabela de Métodos da Classe `FileStream`

| Método                  | Retorno       | Descrição                                                                 |
|------------------------|---------------|---------------------------------------------------------------------------|
| `Read()`               | `int`         | Lê um bloco de bytes do fluxo e grava em um buffer.                      |
| `ReadAsync()`          | `Task<int>`   | Lê bytes de forma assíncrona.                                            |
| `Write()`              | `void`        | Escreve um bloco de bytes no fluxo.                                      |
| `WriteAsync()`         | `Task`        | Escreve bytes de forma assíncrona.                                       |
| `Flush()`              | `void`        | Limpa o buffer e grava os dados pendentes no arquivo.                    |
| `FlushAsync()`         | `Task`        | Versão assíncrona de `Flush()`.                                          |
| `Seek()`               | `long`        | Define a posição no fluxo com base em um deslocamento e origem.          |
| `SetLength()`          | `void`        | Define o comprimento do fluxo.                                           |
| `Close()`              | `void`        | Fecha o fluxo e libera os recursos.                                      |
| `Dispose()`            | `void`        | Libera os recursos usados pelo `FileStream`.                             |
| `CopyTo()`             | `void`        | Copia os dados do fluxo atual para outro fluxo.                          |
| `CopyToAsync()`        | `Task`        | Versão assíncrona de `CopyTo()`.                                         |
| `BeginRead()` *(obsoleto)* | `IAsyncResult` | Inicia uma leitura assíncrona (não recomendado em código novo).         |
| `BeginWrite()` *(obsoleto)*| `IAsyncResult` | Inicia uma escrita assíncrona (não recomendado em código novo).         |

*/