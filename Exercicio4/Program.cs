/*
 Leia dois números inteiros e mostre:

soma
subtração
multiplicação
divisão inteira
*/

Console.WriteLine("Digite o primeiro número:");
var numero1 = Console.ReadLine();
var numero1Convertido = double.Parse(numero1);

Console.WriteLine("Digite o segundo número:");
var numero2 = Console.ReadLine();
var numero2Convertido = Convert.ToDouble(numero2);

Console.WriteLine($"A SOMA de {numero1Convertido} com {numero2Convertido} é {numero1Convertido + numero2Convertido}");

Console.WriteLine($"A SUBTRAÇÃO de {numero1Convertido} com {numero2Convertido} é {numero1Convertido - numero2Convertido}");

Console.WriteLine($"A MULTIPLICAÇÃO de {numero1Convertido} com {numero2Convertido} é {numero1Convertido * numero2Convertido}");

Console.WriteLine($"A DIVISÃO INTEIRA de {numero1Convertido} com {numero2Convertido} é {numero1Convertido / numero2Convertido:F2}");
