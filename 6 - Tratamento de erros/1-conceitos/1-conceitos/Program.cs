/*
 
Em C#, uma excessão é um objeto que herda da classe System.Exception que é criado ou lançado quando ocorre uma condição de erro e que contém informações que devem ajudar a identificar o problema ocorrido. 

Ao ocorrer uma exceção, ela é lançada da área do código onde ocorreu o problema e passada para cima na pilha de chamadas de método em execução, até que seja tratada ou que o programa seja encerrado.
 
Bloco try-catch-finally:

try -> contém o código protegido que pode causar a exceção e é executado até que uma exceção seja lançada ou seja concluído com sucesso. Requer um ou mais blocos catch, um único bloco finally ou ambos.

catch -> especifica o tipo de exceção a tratar e captura e realiza o tratamento da exceção gerada no bloco try, lança a exceção para o método que fez a chamada ou apenas a ignora. Podemos ter múltiplos blocos catch com diferentes tipos de exceção a tratar e eles são avaliados a partir de cima para baixo, mas somente um bloco catch é executado para cada exceção.

finnaly -> é opcional e será executado ocorra ou não a exceção e permite que você execute determinado código como liberar os objetos alocados na memória, fechar arquivos abertos, etc.

### 🧾 Tabela de Propriedades da Classe `Exception` (C#)

| Propriedade       | Tipo           | Descrição                                                                 |
|-------------------|----------------|---------------------------------------------------------------------------|
| `Message`         | `string`       | Mensagem que descreve o erro.                                             |
| `StackTrace`      | `string`       | Representação em string da pilha de chamadas no momento da exceção.      |
| `InnerException`  | `Exception`    | Exceção que causou a exceção atual, se houver.                           |
| `Source`          | `string`       | Nome do aplicativo ou objeto que causou o erro.                          |
| `TargetSite`      | `MethodBase`   | Método que lançou a exceção atual.                                       |
| `HelpLink`        | `string`       | Link para um arquivo de ajuda associado à exceção.                       |
| `HResult`         | `int`          | Código numérico associado à exceção (útil para interoperabilidade COM).  |
| `Data`            | `IDictionary`  | Coleção de pares chave/valor com informações adicionais definidas pelo usuário. |

*/

try
{
    Console.WriteLine("Informe o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine());   // aqui pode acontecer erro de OverflowException (alto numero de caracteres inseridos estourando Int)

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine());     // aqui pode acontece erro DivideByZeroException

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");   // aqui pode acontecer FomatException
}

//catch(Exception e)
//{
//    Console.WriteLine($"\n{e.GetType()} informa : {e.Message}");
//    Console.WriteLine($"\n{e.Message}");
//    Console.WriteLine($"\n{e.Source}");
//    Console.WriteLine($"\n{e.StackTrace}");
//}

catch(FormatException)
{
    Console.WriteLine($"\nInfome um valor inteiro!");
}

catch (OverflowException)
{
    Console.WriteLine($"\nInfome um valor inteiro ente 1 e 999999!");
}

catch (DivideByZeroException)
{
    Console.WriteLine($"\nNão existe divisão por zero!");
}

catch(Exception ex) // preferivel deixar a exceção geral por último, para não ser utilizada em casos específicos acima
{
    Console.WriteLine(ex.Message);
}
Console.ReadKey();