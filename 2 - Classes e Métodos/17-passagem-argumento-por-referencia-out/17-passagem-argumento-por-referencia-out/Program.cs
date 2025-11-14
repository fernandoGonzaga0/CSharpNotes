/*
Na passagem de argumento por referência usando o método OUT, não passaremos um valor no parâmetro. A inserção de valor será feita dentro do método.

A sintaxe é a mesma de REF, sendo necessário destacar no parâmetro do método e durante sua invocação no objeto.
 
*/

// O objetivo é calcular a área e o perímetro de um círculo. Para encurtar o código, vamos fazer com que a única entrada seja do raio, visto que com ele
// conseguimos encontrar a área e o perímetro. 
// A opção burocrática seria criar dois métodos (calculaArea e calculaPerimetro), mas vamos criar apenas um
public class Circulo
{
    public double CalcularAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2); // aqui estamos criando a variável que retornará o valor do parâmetro que o usuário fará a inserção
                                            // isso se torna possível porque conseguimos calcular a área apenas com o valor do raio, sem o user precisar inserir o dado
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Informe o raio do círuclo: \n");
        double raio = Convert.ToDouble(Console.ReadLine());

        Circulo objetoCirculo = new();
        double perimetro = objetoCirculo.CalcularAreaPerimetro(raio, out double area); // aqui estamos chamando o método CalcularAreaPerimetro, que tem como entrada obrigatória apenas o raio, que já obtemos pelo input
                                                                                       // como a área é calculada dentro do próprio método por OUT, não precisamos inserir o valor dela propriamente, pois com o raio já conseguimos encontrar seu valor
        Console.WriteLine("\nÁrea da circunferência: " + area);
        Console.WriteLine("\nPerímetro da circunferência: " + perimetro);
    }
}