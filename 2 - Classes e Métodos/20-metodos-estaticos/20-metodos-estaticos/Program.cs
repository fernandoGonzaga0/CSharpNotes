/*
Métodos estáticos são métodos que não dependem de um objeto. Ou seja, não dependem da criação de uma instância da classe para serem acessados.

Os métodos estáticos pertencem à classe e não ao objeto.

static pode ser usado em -> classes, interfaces, structs, campos, métodos, propriedades, operadores, eventos, construtores

Resumo: um método, variável ou propriedade marcada com static pode ser acessada diretamente pela classe, sem precisar criar um objeto.
 
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

        int resultado2 = Calculadora.Subtrair(4, 2); // o erro acontece por Subtrair ser um método não estático, necessitando então que seja criado o objeto
    }
}
