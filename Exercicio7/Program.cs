/*
Peça um número inteiro.
Use try/catch .

Se o usuário digitar texto:
Mostrar: "Entrada inválida. Digite apenas números."

 */

Console.WriteLine("Digite um número INTEIRO");

try
{
    var numero = int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Digite um número Válido.");
}
catch (OverflowException ex)
{
    Console.WriteLine($"Digite um número entre {int.MinValue} e {int.MaxValue}");
}