// OPERADOR TERNÁRIO

// Usado como uma pergunta, se algo é verdadeiro -> primeira opção, se algo é falso -> segunda opção

// var pergunta = numero > 10 ? "Verdadeiro" : "Falso";


Console.WriteLine("Termomêtro\nInsira a temperatura atual: ");

double temperatura = Convert.ToDouble(Console.ReadLine());

var resultado = temperatura > 23 ? "Está quente." : "Está frio.";

Console.WriteLine(resultado);