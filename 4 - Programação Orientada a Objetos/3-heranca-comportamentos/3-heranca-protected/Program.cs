// Um membro com o modificador protected é acessível dentro da sua classe e por instâncias das classes derivadas.

// Uma classe derivada tem acesso aos membros definidos com o modificador public, internal, protected, protected internal de uma classe.

// Membros com o modificador private embora sejam herdados não podem ser acessados pela classe derivada. 

public class ClasseDerivada : ClasseBase
{
    public void VerificandoAcesso()
    {
        Public_Membro();
        Protected_Membro();
        Protected_Internal_Membro();
        Internal_Membro();
        Private_Membro(); // esse private não pode ser acessado diretamente (se houvesse um get set seria possível)
    }
}

public class ClasseBase
{
    // public
    public void Public_Membro()
    {
        Console.WriteLine("ClasseBase - Método Public");
    }

    // protected
    protected void Protected_Membro()
    {
        Console.WriteLine("ClasseBase - Método Protected");
    }

    // internal
    internal void Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Internal");
    }

    // protected internal
    protected internal void Protected_Internal_Membro()
    {
        Console.WriteLine("ClasseBase - Método protected internal");
    }

    // private
    private void Private_Membro()
    {
        Console.WriteLine("ClasseBase - Método private");
    }

}