// Passagem por valor

public class PorValor
{
    public static void TrocarValor(int numero)
    {
        numero = 999;
        Console.WriteLine("Número dentro do método: " + numero);
    }

    public static void Main()
    {
        int valor = 20;
        TrocarValor(valor);
        Console.WriteLine("Número fora do método: " + valor);
    }
}
