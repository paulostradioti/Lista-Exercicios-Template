/*
 Peça:

    nome do produto
    preço unitário
    quantidade

Calcule:
    valor total
    Mostre:
    
    Resumo da compra:
    Produto: X
    Quantidade: X
    Total: R$ X
Use:
OK - variáveis
OK - conversões
OK - concatenação/interpolação
OK - try/catch para preço e quantidade
OK - Sem laços.
*/
Console.WriteLine("Simulador de Compra" );

Console.Write("Digite o Nome do Produto:");
var nomeProduto = Console.ReadLine();

double precoProduto = 0;
try
{
    Console.Write("Digite o Preço do Produto:");
    precoProduto = double.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Erro na conversão do Preço do Produto.");
}

double quantidadeProduto = 0;
try
{
    Console.Write("Digite a Quantidade comprada do Produto:");
    quantidadeProduto = double.Parse(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Erro na conversão da Quantidade do Produto.");
}

Console.WriteLine("Resumo da Compra:");
Console.WriteLine($"Produto: {nomeProduto}");
Console.WriteLine($"Preço Unitário: R$ {precoProduto:F2}");
Console.WriteLine($"Quantidade: {quantidadeProduto}");
Console.WriteLine("------------------");
Console.WriteLine($"Total da Compra: R$ {quantidadeProduto * precoProduto:F2}");