// Passagem por referência

namespace PorReferencia;
public class PorReferencia
{
    public static void ZerandoNumero(ref int numero)
    {
        numero = 0;
        Console.WriteLine("Valor do número no método: " + numero);
    }

    public static void Main()
    {
        int valor = 45;
        Console.WriteLine("Valor inicial do número: " + valor);
        ZerandoNumero(ref valor);
        Console.WriteLine("Valor do número fora do método: " + valor);
    }
}