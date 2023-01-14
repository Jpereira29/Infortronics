Console.WriteLine("Digite um número para ver a tabuada:");
var num = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("\n****************");
for (int i = 0; i <= 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{num} X {i} = {num * i}");
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("****************");
Console.ResetColor();

Console.ReadLine();