/*
 
Peça dois números.
Use try/catch para evitar erro de conversão.
Se der erro:
Mostrar mensagem amigável e encerrar.

 */

Console.WriteLine("Digite o primeiro número real:");
var numero1 = Console.ReadLine();

Console.WriteLine("Digite o segundo número real:");
var numero2 = Console.ReadLine();

try
{
    var numero1Convertido = Convert.ToInt32(numero1);
}
catch (Exception)
{
    Console.WriteLine("Houve erro na conversão do primeiro número.");
}

try
{
    var numero2Convertido = Convert.ToInt32(numero2);
}
catch (Exception)
{
    Console.WriteLine("Houve erro na conversão do segundo número.");
}

/// -----------------------------
/// 
//try
//{
//    Console.WriteLine("Digite o primeiro número real:");
//    var numero1 = Console.ReadLine();

//    Console.WriteLine("Digite o segundo número real:");
//    var numero2 = Console.ReadLine();

//    var numero1Convertido = Convert.ToInt32(numero1);
//    var numero2Convertido = Convert.ToInt32(numero2);
//}
//catch (Exception)
//{
//    Console.WriteLine("Houve erro na conversão.");
//}