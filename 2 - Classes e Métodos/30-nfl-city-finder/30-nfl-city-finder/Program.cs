class Program
{
    public static void FindCity(string? TeamName)
    {
        switch (TeamName)
        {
            case "Bears":
                Console.WriteLine($"Você escolheu o time {TeamName}! Eles jogam na cidade de Chicago.");
                break;
            case "Packers":
                Console.WriteLine($"Você escolheu o time {TeamName}! Eles jogam na cidade de Green Bay.");
                break;
            case "Lions":
                Console.WriteLine($"Você escolheu o time {TeamName}! Eles jogam na cidade de Detroit.");
                break;
            case "Vikings":
                Console.WriteLine($"Você escolheu o time {TeamName}! Eles jogam na cidade de Minnessota.");
                break;
            default:
                Console.WriteLine("Time inválido!");
                break;
        }
    }
    static void Main()
    {
        Console.WriteLine("--- ENCONTRANDO CIDADE - NFC NORTH\n");

        int menu;
        string? nomeTime;

        do
        {
            Console.WriteLine("Qual opção você deseja?\n1 - Inserir apelido do time | 2 - Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            while (menu != 1 && menu != 2)
            {
                Console.WriteLine("Opção inválida!\n\nQual opção você deseja?\n1 - Inserir apelido do time | 2 - Sair");
                menu = Convert.ToInt32(Console.ReadLine());
            }

            if (menu == 1)
            {
                Console.WriteLine("Insira o apelido do time: ");
                nomeTime = Console.ReadLine();
                FindCity(nomeTime);
            }
        }
        while (menu != 2);

        Console.WriteLine("Encerrando programa...");
    }
}