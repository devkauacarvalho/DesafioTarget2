namespace DesafioTargetFibonacci.Models
{
    public class Fibonacci
    {
        // Inicia a lista da sequência com os valores 0 e 1
        List<int> sequenciaDeFibonacci = new List<int> {0, 1};

        public void calcularSequencia (int numeroInformado)
        {
            // Enquanto o número informado for maior que o último número da lista,
            // soma os dois últimos e adiciona o resultado na lista.
            while (numeroInformado > sequenciaDeFibonacci[sequenciaDeFibonacci.Count - 1])
            {
                int ultimoNumeroDaSequecia = sequenciaDeFibonacci[sequenciaDeFibonacci.Count - 1];
                int penultimoNumeroDaSequecia = sequenciaDeFibonacci[sequenciaDeFibonacci.Count - 2];

                sequenciaDeFibonacci.Add(penultimoNumeroDaSequecia + ultimoNumeroDaSequecia);

                
            }
            // Verifica e escreve se a sequência calculada contém o numero informado pelo usuário
            if (sequenciaDeFibonacci.Contains(numeroInformado))
            {
                Console.WriteLine($"O número {numeroInformado} está na sequência de Fibonacci!\n" + $"{string.Join(", ", sequenciaDeFibonacci)}");
            }
            else
            {
                Console.WriteLine($"O número {numeroInformado} NÃO está na sequência de Fibonacci.\n" + $"{string.Join(", ", sequenciaDeFibonacci)}");
            }
        }
    }
}