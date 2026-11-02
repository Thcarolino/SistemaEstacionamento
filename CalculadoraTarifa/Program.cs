
using System;

Console.WriteLine("==================================");
Console.WriteLine(" CALCULADORA DE ESTACIONAMENTO");
Console.WriteLine("==================================");

const double tarifaPorHora = 5.00;
const double tetoDiario = 30.00;

Console.Write("Digite o tempo estacionado em minutos: ");
int minutos = int.Parse(Console.ReadLine()!);

if (minutos < 0)
{
    Console.WriteLine("Erro: o tempo não pode ser negativo.");
    return;
}

// Conversão do tempo
int horas = minutos / 60;
int minutosRestantes = minutos % 60;

// Cobrança por hora iniciada
int horasCobradas = minutos / 60;

if (minutos % 60 > 0)
{
    horasCobradas++;
}

// Cálculo da tarifa
double valorCalculado = horasCobradas * tarifaPorHora;

// Comparação com o teto diário
bool ultrapassouTeto = valorCalculado > tetoDiario;

double valorFinal = ultrapassouTeto
    ? tetoDiario
    : valorCalculado;

// Exibição dos resultados
Console.WriteLine();
Console.WriteLine("========== RESULTADO ==========");
Console.WriteLine($"Tempo total: {minutos} minutos");
Console.WriteLine($"Permanência: {horas}h {minutosRestantes}min");
Console.WriteLine($"Horas cobradas: {horasCobradas}");
Console.WriteLine($"Valor calculado: R$ {valorCalculado:F2}");
Console.WriteLine($"Ultrapassou o teto diário? {ultrapassouTeto}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
Console.WriteLine("===============================");

