/*
Métodos estáticos são métodos que não dependem de um objeto. Ou seja, não dependem da criação de uma instância da classe para serem acessados.

Os métodos estáticos pertencem à classe e não ao objeto.

static pode ser usado em -> classes, interfaces, structs, campos, métodos, propriedades, operadores, eventos, construtores

Resumo: um método, variável ou propriedade marcada com static, pode ser acessada diretamente pela classe, sem precisar criar um objeto.
 
*/

// Exemplo

class Calculadora
{
    public static int Somar(int a, int b) // exemplo de método estático
    {
        return a * b;
    }

    public int Subtrair(int a, int b) // exemplo de método não estático, logo, sendo necessáro instanciar para acessar
    {
        return a - b;
    }

    public static void Main()
    {
        int resultado1 = Calculadora.Somar(4, 2); // Somar é um método com static, aqui conseguimos acessar ele diretamente pela classe, sem criar objeto

        Calculadora resultado3 = new Calculadora(); // se não usarmos um método estático como em Subtrair, é necessário instanciar a classe e depois aplicar o método
        resultado3.Subtrair(4, 2);
    }
}