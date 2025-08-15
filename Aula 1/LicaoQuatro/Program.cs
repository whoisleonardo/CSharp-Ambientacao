Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 13)
{
    Console.WriteLine("Criança");
}
if (idade > 13 && idade <= 18)
{
    Console.WriteLine("Adolescente");
}
if (idade > 18 && idade <= 59)
{
    Console.WriteLine("Adulto");
}
if (idade >= 60)
{
    Console.WriteLine("Idoso");
}

