/*
 
horas trabalhadas no mês
Calcule e mostre salário final.

*/

Console.WriteLine("Digite o número de Horas Trabalhadas no Mês:");
float.TryParse(Console.ReadLine(), out var horasTrabalhadas);

Console.WriteLine("Digite o valor/hora:");
float.TryParse(Console.ReadLine(), out var valorHora);

Console.WriteLine($"O pagamento mensal deve ser de: {valorHora*horasTrabalhadas:F2}");