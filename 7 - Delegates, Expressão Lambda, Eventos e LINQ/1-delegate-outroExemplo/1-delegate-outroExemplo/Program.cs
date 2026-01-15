// criando um delegate de Callback para evitar chamada do método, chamando apenas o delegate. O objetivo aqui é exbir também a utilização de delegate como parâmetro em um método.

public class Program
{
    // creatinge a delegate that recieves a method with string
    public delegate void Callback(string message);

    // creatinge a method for a delegate 
    public static void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }

    // creating a method that recieves the delegate as parameter
    // como Callback é um delegate que recebe uma string e retorna void, podemos instanciá-lo como parâmetro aqui
    public static void MethodWithCallback(int x, int y, Callback showSum) 
    {
        showSum($"The number is: {(x + y)}");
    }

    public static void Main()
    {
        // instantiate the delegate
        Callback handler = DelegateMethod;

        // call the delegate
        handler("Hello Word!");

        // calling the MethodWithCallback to show the delegate working as a parameter
        MethodWithCallback(4, 8, handler);

        Console.ReadKey();
    }

}