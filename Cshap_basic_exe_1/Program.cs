//Definindo variáveis
using System.Globalization;

string nomeCompleto;
char qtdQuartos;
double precoProd;
string[] vet;
string ultimoNome;
int idade;
double altura;

Console.WriteLine("C# Básico Exercício 1");

Console.WriteLine("Entre com seu nome Completo:");
nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa?");
qtdQuartos = char.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
precoProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
vet = Console.ReadLine().Split(' ');
ultimoNome = vet[0];
idade = int.Parse(vet[1]);
altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

Console.WriteLine("Seu nome completo é: " + nomeCompleto);
Console.WriteLine("Sua casa possui " + qtdQuartos + " quartos");
Console.WriteLine("O preço do seu produto é: R$" + precoProd.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Seu último nome é: " + ultimoNome + " Sua idade é: " + idade + " Sua altura: " + altura.ToString("F2",CultureInfo.InvariantCulture));
