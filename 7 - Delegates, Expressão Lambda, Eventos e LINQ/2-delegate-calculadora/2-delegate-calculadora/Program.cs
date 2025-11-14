// Aplicando o delegate na chamada dos métodos da classe Calculadora (delegate faz com que um método tenha outro médodo como parâmetro)

using _2_delegate_calculadora;

// 1° forma de chamada de delegate
DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Multiplicar);
var resultado1 = calc.Invoke(20, 30);
Console.WriteLine($"Multiplicação = {resultado1}");


// 2° forma de chamada de delegate
calc = Calculadora.Multiplicar;
var resultado2 = calc.(20, 30);
Console.WriteLine($"Multiplicação = {resultado2}");

// 3° forma de chamada de delegate
calc = (float x, float y) => Calculadora.Multiplicar(x, y);
var resultado3 = calc.Invoke(20, 30);
Console.WriteLine($"Multiplicação = {resultado3}");

Console.ReadKey();

// delegate
public delegate float DelegateCalculadora(float x, float y); // a assinatura dos métodos (tipagem dos parâmetros = float) deve ser igual ao método que tentaremos usar delegate


/*
 
Por que usar? 

Com delegate, conseguimos utilizar a mesma instância da classe Calculadora, nomeada de 'calc', e aplicar todos os métodos em momentos separados, ao invés de criar uma instância para cada método.
 
*/