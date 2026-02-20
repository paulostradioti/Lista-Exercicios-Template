/*
Área do Triângulo e do Retângulo
Peça base e altura.
Mostre:
área
perímetro
 */

Console.WriteLine("Digite o tamanho da base do triangulo (em cm):");
double.TryParse(Console.ReadLine(), out var tamanhoBase);

Console.WriteLine("Digite o tamanho da altura do triangulo (em cm):");
double.TryParse(Console.ReadLine(), out var tamanhoAltura);

var areaTriangulo = (tamanhoBase * tamanhoAltura) / 2;
Console.WriteLine($"A area do Triangulo com base {tamanhoBase} e altura {tamanhoAltura} é {areaTriangulo}");

var areaRetangulo = tamanhoBase * tamanhoAltura;
Console.WriteLine($"A area do Retângulo com base {tamanhoBase} e altura {tamanhoAltura} é {areaRetangulo}");