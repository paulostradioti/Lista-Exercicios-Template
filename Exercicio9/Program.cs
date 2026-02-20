/*
Divisão segura

Peça dois números e faça a divisão.

Tratar:
erro de conversão
divisão por zero
Mostrar mensagens apropriadas.

Quando acontece um erro de divisão por Zero em C#?
-> Quando você divide tipos de números INTEIROS (short, long, int, byte, etc. ver https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) 
    Lançam exceção quando dividios por ZERO.

-> O único tipo numérico de ponto flutuante (número real) que LANÇA essa exceção de divisão por ZERO é o DECIMAL.

Os tipos numéricos reais (ponto flutuante): float e o double não lançam essa exceção.

*/

try
{
    Console.WriteLine("Digite o primeiro número:");
    var numero1 = int.Parse(Console.ReadLine());

   Console.WriteLine("Digite o segundo número:");
    var numero2 = int.Parse(Console.ReadLine());

    var resultado = numero1 / numero2;
}
catch (OverflowException)
{
    Console.WriteLine($"Digite um número entre {int.MinValue} e {int.MaxValue}");
}
catch (FormatException)
{
    Console.WriteLine($"Digite apenas números");
}
catch (DivideByZeroException)
{
    Console.WriteLine($"Erro de Divisão por zero");
}