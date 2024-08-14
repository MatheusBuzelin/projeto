// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Padrão de variavel ComeCalse, NomeCompleto
int Inteiro = 10;
double PontoDecimal = 49.99;

// Boleano só aceita verdadeiro ou false (true/false)

bool Boleano = true;

Console.WriteLine($"Inteiro: {Inteiro}");
Console.WriteLine($"double: {PontoDecimal}");
Console.WriteLine($"bool: {Boleano}");


// > Maior
// < Menor
// >= Maior ou igual
// <= Menor ou igual
// == Igualdade ou igual
// =  Atribuição ( não é comparativo)
// != Diferente

Console.WriteLine($"3 > 4: {3 > 4}");
Console.WriteLine($"3 < 4: {3 < 4}");
Console.WriteLine($"3 >= 4: {3 >= 4}");
Console.WriteLine($"3 <= 4: {3 <= 4}");
Console.WriteLine($"3 == 4: {3 == 4}");
Console.WriteLine($"3 != 4: {3 != 4}");

// && e
Console.WriteLine($"{(3 < 4) && (5==5)}");
// || ou
Console.WriteLine($"{(3 < 4) || (5==5)}");
// ! não
Console.WriteLine($" {!(3 < 4)}");


/* TABELA VERDADE && ( E/AND)
ValA  | ValB | ValA && ValB |
  V   |   V    |     V      |
  V   |   F    |     F      |
  F   |   V    |     F      |
  F   |   F    |     F      |
  */

bool ValA, ValB;

Console.WriteLine("TABELA VERDADE && ( E/AND)");
ValA = true;
ValB = true;
Console.WriteLine($"V && V ={ValA && ValB}");

ValA = true;
ValB = true;

Console.WriteLine($"V && V ={ValA && ValB}");

ValA = true;
ValB = true;

Console.WriteLine($"V && V ={ValA && ValB}");

ValA = true;
ValB = true;

Console.WriteLine($"V && V ={ValA && ValB}");

ValA = true;
ValB = true;