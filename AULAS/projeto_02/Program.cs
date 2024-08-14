// int valor1, valor2, valor3, resultado;
// valor1 = 10;
// valor2 = 5;
// valor3 = 2;
//  resultado = valor1 + valor2 - valor3;
// Console.WriteLine(valor2 * valor3);
// Console.WriteLine(valor1 / valor3);
// resultado = 2 + 3 * 10; // = 32
//  Console.WriteLine(resultado);

//  resultado = (2+3) * 10;
//  Console.WriteLine(resultado);
// Control + /

using System;
using System.Globalization;

namespace projeto_02;

internal class Program
{
    private static void Main(string[] args)
    {
        double valor1, valor2;

        Console.Write("Digite um valor: ");
        valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite outro valor: ");
        valor2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.WriteLine($"Valor: {(valor1 + valor2).ToString ("F2",CultureInfo.InvariantCulture)}");
        
        // + - * / ++ -- % SÃO OPERADORES ARITMÉTICAS

        Console.WriteLine($"Soma:           {( valor1 + valor2)}");
        Console.WriteLine($"Subtração:      {( valor1 - valor2)}");
        Console.WriteLine($"Multiplicação:  {( valor1 * valor2)}");
        Console.WriteLine($"Divisão:        {( valor1 / valor2)}");

        // valor1 = valor1 +1;
        Console.WriteLine($"Adição:         {( valor1 ++)}");
        Console.WriteLine($"Adição:         {( ++valor1)}");

        // valor1 = valor1 -1;
        Console.WriteLine($"Subtração:      {( valor1 --)}");
        Console.WriteLine($"Subtração:      {( --valor1)}");

        // resto da divisão
        Console.WriteLine($"Módulo: 4 / 3 , o resto da divisão é:   { 4 % 3}");  

      










    }
}