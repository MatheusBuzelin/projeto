// See https://aka.ms/new-console-template for more information

 byte anos, meses, dias;

        Console.Write(" Quantos anos: ");
        anos = byte.Parse(Console.ReadLine());

        Console.Write(" Quantos meses: ");
        meses = byte.Parse(Console.ReadLine());

        Console.Write(" Quantos dias: ");
        dias = byte.Parse(Console.ReadLine());

        int total;

        total = anos * 365;
        total = total + meses * 30;
        total = total + dias;

        Console.Write($"Valor total em dias:{total} ");