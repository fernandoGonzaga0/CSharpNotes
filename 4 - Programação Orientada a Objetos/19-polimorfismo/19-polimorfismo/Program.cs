/*
 
Polimorfismo = de muitas formas.

Ele permite que objetos de diferentes classes sejam tratados como objetos de uma mesma classe base, especialmente ao usar herança e interfaces.

TIPOS

1) Polimorfismo em tempo de compilação -> utiliza a sobrecarga de métodos e operadores sendo também chamado de ligação precoce (early binding). A utilização
da sobrecarga (overloading) de métdos realiza a tarefa cm distintos parâmetros de entrada. Permite que classes forneçam diferentes implementações de métodos
que são chamados pelo mesmo nome.

2) Polimorfismo em tempo de execução -> pode ser feito usando herança e métodos virtuais. Quando sobrescrevemos (override) os métodos virtuais estamos alterando
o comportamento dos métodos para a classe derivada. Isto também é conhecido como ligação tardia (late binding). Permite invocar métodos da classe derivada através
da classe base em tempo de execução.

IMPLEMENTAÇÕES

1) Polimorfismo com herança -> classes derivadas sobrescrevendo os membros da classe base.
2) Polimorfismo com interface -> classes que implementam a interface com comportamentos diferentes | métodoos com mesmo nome nas classes mas funcionalidades diferentes
3) Polimorfismo com classe abstrata -> classes derivadas incluem os detalhes de implementação nos métodos abstratos.

*/

// Ex onde tenho uma classe Figura que contém o método Desenha(), 3 outras classes derivadas vão usar de forma única esse mesmo método.

namespace _19_polimorfismo;

class Program
{
    public static void Main()
    {
        var figuras = new List<Figura>  // inserindo a classe Figura na lista figuras
        {
            new Triangulo(),
            new Circulo(),
            new Quadrado()
        };

        foreach (var figura in figuras)
        {
            figura.Desenhar();
        }
    }
}