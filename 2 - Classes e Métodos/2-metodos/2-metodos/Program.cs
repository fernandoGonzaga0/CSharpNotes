/*

Método/função é criado para atribuir alguma ação dentro de uma classe (obrigatoriamente dentro de uma classe)
 
*/

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem-Vindo!");
    }

    public void ExibirDataAtual()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
    }
        
}

class Program
{
    public void Main()
    {
        // objeto chamando os dois métodos (Saudacao e ExibirDataAtual na classe MinhaClasse)
        MinhaClasse objeto1 = new MinhaClasse();
        objeto1.Saudacao();
        objeto1.ExibirDataAtual();
    }
}