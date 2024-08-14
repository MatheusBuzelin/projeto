// See https://aka.ms/new-console-template for more information

int dias, horas,minutos, segundos;

Console.Write("Digite a quantidade de dias: ");
dias = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de horas: ");
horas = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de minutos: ");
minutos = int.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de segundos: ");
segundos = int.Parse(Console.ReadLine());

horas = horas + (dias * 24);
minutos = minutos + (horas * 60);
segundos = segundos + (minutos * 60);

Console.WriteLine($" O valor convertido em segundos é: {segundos}");