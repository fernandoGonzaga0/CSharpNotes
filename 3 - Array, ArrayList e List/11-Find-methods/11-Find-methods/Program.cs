/*
 
Em List<T> podemos usar os métodos abaixo:

Find() -> encontra o primeiro elemento que corresponde ao predicado fornecido
FindLast -> encontra o último
FindIndex -> Retorna o índice
FindLastIndex -> Retorna o índice do último elemento que corresponde ao predicado fornecido. 
FindAll -> Recupera todos os elementos que correspondem às condições definidas pelo predicado especificado.

 */

List<string> Nfl = new()
{
    "Packers", "Giants", "Ravens", "Steelers", "Buccanners", "Eagles"
};

// criando uma condição para aplicar ao método Find()
static bool Procura(string item) // predicato (basicamente uma função de condição)
{
    return item.Contains("rs"); // retornando o primeiro elemento que possua 'rs' na cadeia de string
}

// FIND()

    // Usando a condição Procura como parâmetro em Find()
    var GreenBay = Nfl.Find(Procura);
    Console.WriteLine($"FIND(): Por predicado -> {GreenBay}");

    // Usando EXPRESSÃO LAMBDA como parâmetro

    // chamando time que possua 'cc' no nome com expressão lambda
    var TambaBay = Nfl.Find(n => n.Contains("cc")); // ( parametros de entrada na esquera => critério de busca)
    Console.WriteLine($"FIND(): Por expressão lambda -> {TambaBay}");

// FINDLAST()

    var lastTeam = Nfl.FindLast(n => n.Contains("gle"));
    Console.WriteLine($"FINDLAST(): {lastTeam}");

// FINDINDEX()

    var teamWithccanne = Nfl.FindIndex(n => n.Contains("nn")); // busca o index do prmeiro elemento que conter 'ccanne', para exibir o valor, fazer como abaixo
    Console.WriteLine($"FINDINDEX: ID = {teamWithccanne}, Item = {Nfl[teamWithccanne]}");

// FINDLASTNDEX()

    var lastTeamWithEns = Nfl.FindLastIndex(n => n.Contains("ens")); // será retornado o index do últmo elemento que conter 'ens'
    Console.WriteLine($"FINDLASTINDEX(): ID = {lastTeamWithEns}, Item = {Nfl[lastTeamWithEns]}");

// FINDALL()

    var teamsWithL = Nfl.FindAll(i => i.Contains('l'));
    Console.WriteLine("FINDALL: ");
    // como FindAll retorna uma lista, sua exibição deve ser com for/foreach
    foreach (var item in teamsWithL)
    {
        Console.Write($"{item}");
    }