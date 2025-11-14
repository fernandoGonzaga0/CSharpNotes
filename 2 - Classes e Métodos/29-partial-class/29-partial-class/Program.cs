/*

Partial class permite que uma mesma classe seja dividida e configurada em múltiplos arquivos. 

É útil quando: quer organizar o código (separando propriedades, métodos, eventos, etc.); projeto grande.

Regras:

    i) Todos os arquivos devem usar a mesma palavra-chave 'partial';
    ii) Todos os trechos devem ter o mesmo nome de classe e estar no mesmo namespace;
    iii) Na hora da compilação, o compilador junta tudo como se fosse uma única classe;
 
*/

// Ex atual -> dois arquivos (de propriedades e métodos) serão utilizados na chamada aqui em Program.cs

using System;
using FuncionarioNamespace; // importando o namespace nas duas classes do arquivo 

class Program
{
    static void Main()
    {
        Funcionario func1 = new();
        func1.Nome = "Fernando";
        func1.Idade = 25;
        func1.Salario = 5600;
        func1.ExibirDados();
    }
}