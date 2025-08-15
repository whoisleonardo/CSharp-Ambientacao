Console.WriteLine("Informe o valor em reais: ");
    float valorReais = float.Parse(Console.ReadLine());
    float valorDolares = valorReais / 5.17f;
    float valorEuros = valorReais / 6.14f;
    float pesosArgentinos = valorReais / 0.05f;
Console.WriteLine("Valor em dólares: " + valorDolares);
Console.WriteLine("Valor em euros: " + valorEuros);
Console.WriteLine("Valor em pesos argentinos: " + pesosArgentinos);