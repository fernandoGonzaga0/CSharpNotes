/*
 
Esse é um exemplo demostrando herança + composição.

Teremos 4 animais: humano, macaco, sardinha e pato.

Métodos comuns: Comer, Dormir.
Propriedade comum: Idade.

Métodos específicos: Andar, Nadar, Voar.
 
 */

namespace _18_heranca_composicao;

public class Animal
{
    public int Idade {  get; set; }
    public void Comer() { }
    public void Dormir() { }
}

public class Program
{
    static void Main()
    {
        ComportamentoAndar andar = new();
        ComportamentoNadar nadar = new();
        ComportamentoVoar voar = new();

        var homem = new Homem(andar);
        var macaco = new Macaco(andar);
        var sardinha = new Sardinha(nadar);
        var pato = new Pato(voar);

        homem.Locomocao();
        macaco.Locomocao();
        sardinha.Locomocao();
        pato.Locomocao();

    }
}