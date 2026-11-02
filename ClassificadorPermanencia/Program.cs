
using System;

Console.WriteLine("==================================");
Console.WriteLine(" CLASSIFICADOR DE PERMANÊNCIA");
Console.WriteLine("==================================");

Console.Write("Digite o tempo estacionado em minutos: ");

string? entrada = Console.ReadLine();

if (!int.TryParse(entrada, out int minutos) || minutos < 0)
{
    Console.WriteLine("Erro: informe um número inteiro válido.");
    return;
}

string classificacao;

if (minutos <= 60)
{
    classificacao = "Rotativa Curta";
}
else if (minutos <= 180)
{
    classificacao = "Padrão";
}
else
{
    classificacao = "Diária";
}

Console.WriteLine();
Console.WriteLine("========== RESULTADO ==========");
Console.WriteLine($"Tempo informado: {minutos} minutos");
Console.WriteLine($"Classificação: {classificacao}");
Console.WriteLine("===============================");

