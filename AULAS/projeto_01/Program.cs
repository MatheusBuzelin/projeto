using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Alo,mundo");

        char letra ='a';
        string texto = "abobrinha";

        Console.WriteLine("A letra escolhida foi: "+ letra);
        Console.WriteLine("O texto escolhida foi: "+ texto);
        int inteiro =20;
        float numero1 = 10;
        double numero2 = 10;

        Console.WriteLine($"A soma dos valores é: {numero1+numero2}");
        Console.WriteLine($"A soma dos valores multiplicado por 10 é: {(numero1 + numero2)* inteiro}");

        Console.WriteLine("\n");
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {nome}");

    }

    private string GetDebuggerDisplay()
    {  
        return ToString();
    }
}