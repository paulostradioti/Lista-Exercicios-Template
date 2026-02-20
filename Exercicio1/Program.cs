// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um Número:");
var numero = Console.ReadLine();
var numeroConvertido = Convert.ToInt32(numero);

var dobro = numeroConvertido * 2;

var mensagem = $"O número que você informou é {numero} e o dobro dele é {dobro}.";
Console.WriteLine(mensagem);