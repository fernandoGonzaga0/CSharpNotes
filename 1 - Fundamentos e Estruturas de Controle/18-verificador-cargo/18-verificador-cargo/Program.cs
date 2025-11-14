using System;

class Program
{
    static void Main()
    {
        int cargo = 0;
        int funcao = 0;
        
        Console.WriteLine("Qual o seu cargo? (1 -> Gerente | 2 -> Programador)");
        cargo = Convert.ToInt32(Console.ReadLine());

        if (cargo == 2)
        {
            Console.WriteLine("Qual o seu nível? (1 -> Jr, 2 -> Sr, 3 -> Pl)");
            funcao = Convert.ToInt32(Console.ReadLine());
        }

        switch(cargo)
        {
            case 1:
                Console.WriteLine("Seja bem vindo Gerente!");
                break;
            case 2:
                Console.WriteLine("Seja bem vindo Programador!");
                switch (funcao)
                {
                    case 1:
                        Console.WriteLine("Você é Junior.");
                        break;
                    case 2:
                        Console.WriteLine("Você é Senior.");
                        break;
                    case 3:
                        Console.WriteLine("Você é Pleno.");
                        break;
                    default:
                        Console.WriteLine("Não consegui identificar sua senioridade.");
                        break;
                }
                break;
            default:
                Console.WriteLine("Não consegui identificar seu cargo.");
                break;

        }

        Console.WriteLine("Fim do processamento...");
    }
}