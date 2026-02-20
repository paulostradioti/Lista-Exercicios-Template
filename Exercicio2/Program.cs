/*

Peça um número inteiro e mostre:
antecessor
sucessor

*/

Console.WriteLine("Digite um número");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"O número digitado é: {numero}");

Console.WriteLine($"O antecessor do número digitado é: {--numero}");
numero++;
Console.WriteLine($"O sucessor de número digitado é: {++numero}");

// Incremento -> ++ (Pré e Pós Incremento)
// Decremento -> -- (Pré e Pós Decremento)