// OBS -> Para executar, comentar uma das classes pois existem métodos Main em cada uma delas

// Em C# é possível passar argumentos para parâmetros de duas formas:

// 1) por valor (padrão do C#) -> uma cópia do valor do argumento é feita e passada para o parâmetro do método chamado.

public class PorValor
{
    public static void Dobrar(int numero) // criando método Dobrar que receberá um int
    {
        numero = numero * 2;
        Console.WriteLine("Dentro do método: " + numero);
    }

    public static void Main()
    {
        int valor = 10; // o argumento tem valor 10
        Dobrar(valor); // aqui passamos o argumento para o método por valor (10) em cópia, mas percebe-se que o valor em si do argumento não muda, apenas seu valor é copiado
        Console.WriteLine("Fora do método: " + valor);
    }
}

//2) por referência -> quando chamarmos o método, estaremos passando a referência ao mesmo local de memória do argumento, fazendo com que ele seja alterado de fato ao invés de ser uma cópia
// Esse método é usado quando queremos alterar de fato um componente quando chamado o método

public class PorReferencia
{
    static void Triplicar(ref int numero) // usar o ref antes do parâmetro, assim será solicitado o endereço de referência no momento de chamada do método
    {
        numero = numero * 3;
        Console.WriteLine("Dentro do método: " + numero);
    }

    public static void Main()
    {
        int valor = 5; // argumento possui valor 5
        Triplicar(ref valor); // usando ref na passagem de valor, o método fará a alteração diretamente no componente int valor, alterando de fato o campo
        Console.WriteLine("Fora do método: " + valor); // demonstrando que o valor foi alterado mesmo fora do método
    }
}