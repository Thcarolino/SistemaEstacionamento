
using System;

Console.WriteLine("====================================");
Console.WriteLine(" CONTADOR DE VEÍCULOS - ESTACIONAMENTO");
Console.WriteLine("====================================");

// Contadores
int curta = 0;
int media = 0;
int longa = 0;
int total = 0;

// Controle da repetição
int minutos = 0;

Console.WriteLine("Informe o tempo de cada veículo.");
Console.WriteLine("Digite -1 para encerrar.");
Console.WriteLine();

while (minutos != -1)
{
    Console.Write("Tempo estacionado (minutos): ");

    string? entrada = Console.ReadLine();

    if (!int.TryParse(entrada, out minutos))
    {
        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        continue;
    }

    if (minutos == -1)
    {
        break;
    }

    if (minutos < 0)
    {
        Console.WriteLine("Tempo inválido. Tente novamente.");
        continue;
    }

    if (minutos <= 60)
    {
        curta++;
        Console.WriteLine("Categoria: Rotativa Curta");
    }
    else if (minutos <= 180)
    {
        media++;
        Console.WriteLine("Categoria: Padrão");
    }
    else
    {
        longa++;
        Console.WriteLine("Categoria: Diária");
    }

    total++;

    Console.WriteLine();
}

// Relatório final
Console.WriteLine();
Console.WriteLine("========== RELATÓRIO FINAL ==========");
Console.WriteLine($"Rotativa Curta: {curta} veículo(s)");
Console.WriteLine($"Padrão: {media} veículo(s)");
Console.WriteLine($"Diária: {longa} veículo(s)");
Console.WriteLine("-------------------------------------");
Console.WriteLine($"Total de veículos: {total}");
Console.WriteLine("=====================================");
