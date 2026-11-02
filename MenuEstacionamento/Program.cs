
using System;

int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("==================================");
    Console.WriteLine("     SISTEMA DE ESTACIONAMENTO");
    Console.WriteLine("==================================");
    Console.WriteLine("1 - Calcular tarifa");
    Console.WriteLine("2 - Classificar permanência");
    Console.WriteLine("3 - Contar veículos por categoria");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("==================================");

    Console.Write("Escolha uma opção: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida!");
        continue;
    }

    switch (opcao)
    {
        case 1:
            CalcularTarifa();
            break;

        case 2:
            ClassificarPermanencia();
            break;

        case 3:
            ContarVeiculos();
            break;

        case 0:
            Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 0);


// MÉTODO 1 - CALCULAR TARIFA
static void CalcularTarifa()
{
    Console.WriteLine();
    Console.WriteLine("=== CALCULADORA DE TARIFA ===");

    Console.Write("Digite o tempo em minutos: ");

    if (!int.TryParse(Console.ReadLine(), out int minutos)
        || minutos < 0)
    {
        Console.WriteLine("Tempo inválido!");
        return;
    }

    const double tarifaHora = 5.00;
    const double tetoDiario = 30.00;

    int horas = minutos / 60;
    int minutosRestantes = minutos % 60;

    int horasCobradas = minutos / 60;

    if (minutos % 60 > 0)
    {
        horasCobradas++;
    }

    double valor = horasCobradas * tarifaHora;

    if (valor > tetoDiario)
    {
        valor = tetoDiario;
    }

    Console.WriteLine($"Permanência: {horas}h {minutosRestantes}min");
    Console.WriteLine($"Horas cobradas: {horasCobradas}");
    Console.WriteLine($"Valor final: R$ {valor:F2}");
}


// MÉTODO 2 - CLASSIFICAR PERMANÊNCIA
static void ClassificarPermanencia()
{
    Console.WriteLine();
    Console.WriteLine("=== CLASSIFICAR PERMANÊNCIA ===");

    Console.Write("Digite o tempo em minutos: ");

    if (!int.TryParse(Console.ReadLine(), out int minutos)
        || minutos < 0)
    {
        Console.WriteLine("Tempo inválido!");
        return;
    }

    if (minutos <= 60)
    {
        Console.WriteLine("Categoria: Rotativa Curta");
    }
    else if (minutos <= 180)
    {
        Console.WriteLine("Categoria: Padrão");
    }
    else
    {
        Console.WriteLine("Categoria: Diária");
    }
}


// MÉTODO 3 - CONTAR VEÍCULOS
static void ContarVeiculos()
{
    Console.WriteLine();
    Console.WriteLine("=== CONTADOR DE VEÍCULOS ===");
    Console.WriteLine("Digite -1 para encerrar.");

    int curta = 0;
    int media = 0;
    int longa = 0;
    int minutos = 0;

    while (minutos != -1)
    {
        Console.Write("Tempo do veículo (minutos): ");

        if (!int.TryParse(Console.ReadLine(), out minutos))
        {
            Console.WriteLine("Entrada inválida!");
            continue;
        }

        if (minutos == -1)
        {
            break;
        }

        if (minutos < 0)
        {
            Console.WriteLine("Tempo inválido!");
            continue;
        }

        if (minutos <= 60)
        {
            curta++;
        }
        else if (minutos <= 180)
        {
            media++;
        }
        else
        {
            longa++;
        }
    }

    Console.WriteLine();
    Console.WriteLine("=== RELATÓRIO DE VEÍCULOS ===");
    Console.WriteLine($"Rotativa Curta: {curta}");
    Console.WriteLine($"Padrão: {media}");
    Console.WriteLine($"Diária: {longa}");
    Console.WriteLine($"Total: {curta + media + longa}");
}

