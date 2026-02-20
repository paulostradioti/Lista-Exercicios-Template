/*
Minicalculadora com método
Crie um método:
int Somar(int a, int b)
No programa principal:
leia dois números
chame o método
mostre resultado
*/

Console.WriteLine("Digite o Primeiro Número:");
int.TryParse(Console.ReadLine(), out var numero1);

Console.WriteLine("Digite o Segundo Número:");
int.TryParse(Console.ReadLine(), out var numero2);

Console.WriteLine($"O resultado da Soma dos números {numero1} e {numero2} é {Soma(numero1, numero2)}");


int Soma(int numeroA, int numeroB)
{
    return numeroA + numeroB;
}