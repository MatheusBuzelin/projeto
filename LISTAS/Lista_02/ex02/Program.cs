// See https://aka.ms/new-console-template for more information

double nota1, nota2, nota3, nota4, media;

        Console.Write("Digite a nota1: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write(" Digite a nota2: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write(" Digite a nota3: ");
        nota3 = double.Parse(Console.ReadLine());

        Console.Write(" Digite a nota4: ");
        nota4 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3 + nota4) / 4;
        Console.Write($" A media é: {media}");
