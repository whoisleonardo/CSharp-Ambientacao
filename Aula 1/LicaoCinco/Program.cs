Console.WriteLine("Informe o númeroi:");
int n = int.Parse(Console.ReadLine());
int a = 0, b = 1, c;
Console.WriteLine("Sequência de Fibonacci:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);
    c = a + b;
    a = b;
    b = c;
}
