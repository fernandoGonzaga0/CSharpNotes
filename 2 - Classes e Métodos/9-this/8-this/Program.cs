/*
 
A palavra THIS refere-se à instância atual da classe.

É usada como um modificador do primeiro parâmetro de um método de extensão.

Representa o objeto que está em execução, e assim, usando this, de forma implícita chamamos o objeto que está sendo usado.

Uso comum: quando criamos uma classe e existe um construtor dentro dela que usa, como parâmetro, palavras iguais que já foram utilizadas nos componentes da classe.

Ex:  

*/

// primeiro uso -> diferenciando o nome de componentes da
public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome; // usando this. estamos referenciando o componente/atributo 'Nome' da classe (o destino), e não o parâmetro 'Nome' do construtor (a origem).
        this.Idade = Idade;
    }
}

// segundo uso -> passar um objeto da instância atual como parâmetro para outros métodos