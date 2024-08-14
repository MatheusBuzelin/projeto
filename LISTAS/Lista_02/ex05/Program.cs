// See https://aka.ms/new-console-template for more information
 // Solicita as medidas do local
        Console.WriteLine("Informe o comprimento do local (em metros):");
        double comprimento = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a largura do local (em metros):");
        double largura = double.Parse(Console.ReadLine());

        Retangulo local = new Retangulo(comprimento, largura);

        double area = local.CalcularArea();
        double perimetro = local.CalcularPerimetro();

        Console.WriteLine($"Área do local: {area} m²");
        Console.WriteLine($"Perímetro do local: {perimetro} m");


        Console.WriteLine("Informe a área de um piso (em m²):");
        double areaPiso = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o tamanho de uma peça de rodapé (em metros):");
        double tamanhoRodape = double.Parse(Console.ReadLine());


        double quantidadePisos = Math.Ceiling(area / areaPiso);
        double quantidadeRodape = Math.Ceiling(perimetro / tamanhoRodape);

        Console.WriteLine($"Quantidade de pisos necessários: {quantidadePisos}");
        Console.WriteLine($"Quantidade de rodapés necessários: {quantidadeRodape}");
