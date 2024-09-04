using System;
using System.IO;
using System.Linq;
using System.Text.Json;

using VetorDeFaturamentos.Models;

    // Ler os dados do arquivo e passar para a variável dadosFaturamentoJson
    string dadosFaturamentoJson = File.ReadAllText("dados.json");

    // Separar os dados do arquivo para o array Faturamento
    var faturamentos = JsonSerializer.Deserialize<Faturamento[]>(dadosFaturamentoJson);

    // Filtrar os dias com faturamento maior do que 0
    var diasComFaturamento = faturamentos.Where(f => f.valor > 0).ToArray();

    // Calcular o menor e maior valor de faturamento
    double menorValor = diasComFaturamento.Min(f => f.valor);
    double maiorValor = diasComFaturamento.Max(f => f.valor);

    // Calcular a média mensal
    double mediaMensal = diasComFaturamento.Average(f => f.valor);

    // Contar o número de dias com faturamento superior à média mensal
    int diasAcimaDaMedia = diasComFaturamento.Count(f => f.valor > mediaMensal);
    
    Console.WriteLine($"Menor valor de faturamento: {menorValor}");
    Console.WriteLine($"Maior valor de faturamento: {maiorValor}");
    Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
