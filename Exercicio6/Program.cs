/*
Peça uma temperatura em Celsius e converta para Fahrenheit.
Fórmula:
F = (C × 9/5) + 32
*/

Console.WriteLine("Digite uma temperatura em graus Celsius:");
var celsius = double.Parse(Console.ReadLine());

var fahrenheit = 32 + (celsius * 9/5);

Console.WriteLine($"O equivalente de {celsius}ºC em Fahrenheit é {fahrenheit}ºF");

