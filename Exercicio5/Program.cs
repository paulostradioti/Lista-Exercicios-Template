// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite uma quantidade em metros:");
var metros = double.Parse(Console.ReadLine());
var centimetros = metros * 100;

Console.WriteLine($"{metros} metros correspondem a {centimetros} centímetros.");
