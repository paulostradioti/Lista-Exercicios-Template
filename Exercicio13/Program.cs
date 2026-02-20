/*
Média de duas provas
    Peça duas notas (double).
    Mostre média com 2 casas decimais.
    Dica:
    Use ToString("F2")
*/

Console.WriteLine("Digite a primeira nota:");
double.TryParse(Console.ReadLine(), out var primeiraNota);

Console.WriteLine("Digite a segunda nota:");
double.TryParse(Console.ReadLine(), out var segundaNota);

Console.WriteLine($"A média é {(primeiraNota + segundaNota) / 2:F2}");
Console.WriteLine($"PRECEDÊNCIA INCORRETA: {primeiraNota + segundaNota / 2:F2}");