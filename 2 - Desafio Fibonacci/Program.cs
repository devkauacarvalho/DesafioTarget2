using DesafioTargetFibonacci.Models;

Console.Write("Digite um número para calcular a sequência de Fibonacci: ");
string input = Console.ReadLine();

// Tenta converter a entrada do usuário em um número inteiro, se não, retorna um erro
if (int.TryParse(input, out int numeroInformado))
{
    Fibonacci sequencia = new Fibonacci();
    sequencia.calcularSequencia(numeroInformado);
}
else
{
    Console.WriteLine("Por favor, insira um número válido.");
}