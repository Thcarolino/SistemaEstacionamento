
using System;

int opcao;

do
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("       SISTEMA DE ESTACIONAMENTO");
    Console.WriteLine("========================================");
    Console.WriteLine("1 - Calcular tarifa");
    Console.WriteLine("2 - Classificar permanência");
    Console.WriteLine("3 - Contar veículos por categoria");
    Console.WriteLine("4 - Informações do ambiente .NET");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("========================================");
    Console.Write("Escolha uma opção: ");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida! Digite um número.");
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

        case 4:
            MostrarAmbiente();
            break;

        case 0:
            Console.WriteLine("Sistema encerrado. Até logo!");
            break;

        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }

} while (opcao != 0);


// MÉTODO PARA CALCULAR A TARIFA
static void CalcularTarifa()
{
    Console.WriteLine();
    Console.WriteLine("=== CALCULADORA DE TARIFA ===");

    Console.Write("Tempo estacionado (minutos): ");

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

    double valorCalculado = horasCobradas * tarifaHora;

    bool ultrapassouTeto = valorCalculado > tetoDiario;

    double valorFinal = ultrapassouTeto
        ? tetoDiario
        : valorCalculado;

    Console.WriteLine();
    Console.WriteLine("=== RESULTADO ===");
    Console.WriteLine($"Permanência: {horas}h {minutosRestantes}min");
    Console.WriteLine($"Horas cobradas: {horasCobradas}");
    Console.WriteLine($"Valor calculado: R$ {valorCalculado:F2}");
    Console.WriteLine($"Ultrapassou o teto? {ultrapassouTeto}");
    Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
}


// MÉTODO PARA CLASSIFICAR A PERMANÊNCIA
static void ClassificarPermanencia()
{
    Console.WriteLine();
    Console.WriteLine("=== CLASSIFICADOR DE PERMANÊNCIA ===");

    Console.Write("Tempo estacionado (minutos): ");

    if (!int.TryParse(Console.ReadLine(), out int minutos)
        || minutos < 0)
    {
        Console.WriteLine("Tempo inválido!");
        return;
    }

    string categoria;

    if (minutos <= 60)
    {
        categoria = "Curta permanência";
    }
    else if (minutos <= 180)
    {
        categoria = "Média permanência";
    }
    else
    {
        categoria = "Longa permanência";
    }

    Console.WriteLine($"Classificação: {categoria}");
}


// MÉTODO PARA CONTAR VEÍCULOS
static void ContarVeiculos()
{
    Console.WriteLine();
    Console.WriteLine("=== CONTADOR DE VEÍCULOS ===");
    Console.WriteLine("Digite -1 para finalizar.");

    int curta = 0;
    int media = 0;
    int longa = 0;

    while (true)
    {
        Console.Write("Tempo do veículo (minutos): ");

        string? entrada = Console.ReadLine();

        if (!int.TryParse(entrada, out int minutos))
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
            Console.WriteLine("Categoria: Curta");
        }
        else if (minutos <= 180)
        {
            media++;
            Console.WriteLine("Categoria: Média");
        }
        else
        {
            longa++;
            Console.WriteLine("Categoria: Longa");
        }
    }

    int total = curta + media + longa;

    Console.WriteLine();
    Console.WriteLine("=== RELATÓRIO FINAL ===");
    Console.WriteLine($"Curta permanência: {curta}");
    Console.WriteLine($"Média permanência: {media}");
    Console.WriteLine($"Longa permanência: {longa}");
    Console.WriteLine($"Total de veículos: {total}");
}


// MÉTODO PARA MOSTRAR O AMBIENTE
static void MostrarAmbiente()
{
    Console.WriteLine();
    Console.WriteLine("=== INFORMAÇÕES DO AMBIENTE ===");

    Console.WriteLine($"Versão do .NET: {Environment.Version}");
    Console.WriteLine($"Sistema operacional: {Environment.OSVersion}");
    Console.WriteLine($"Máquina: {Environment.MachineName}");
    Console.WriteLine($"Processadores lógicos: {Environment.ProcessorCount}");
}

