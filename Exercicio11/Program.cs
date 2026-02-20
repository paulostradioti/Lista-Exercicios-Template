/*
Peça:
valor do produto
valor pago
Mostre:
valor do troco
 */

Console.Write("Digite o valor de um produto: ");
double.TryParse(Console.ReadLine(), out var valorProduto);

Console.Write("Digite o valor pago: ");
double.TryParse(Console.ReadLine(), out var valorPago);

var troco = valorPago -  valorProduto;

if (troco > 0)
    Console.Write($"Seu troco é de {troco:F2}");
if (troco < 0)
    Console.Write($"Você ainda está devendo {troco:F2}");
else
    Console.Write($"Sem troco.");