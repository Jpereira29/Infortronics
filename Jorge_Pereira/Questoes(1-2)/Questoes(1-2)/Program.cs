using Questoes_1_2_.Entities;

try
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Digite os números para adicionar na lista:");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("X para ver os valores ordenados.");
    Console.ResetColor();
    Console.WriteLine("__________________________________________");

    Numbers listNumbers = new Numbers();
    listNumbers.VerifyChar();

    listNumbers.AscendingOrder();
    Console.WriteLine("__________________________________________");

    Console.WriteLine("Salve a lista em um arquivo de texto:");

    Console.WriteLine("Digite o path do arquivo para savar as informações:");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ex: C:\\Temp\\numbers.txt");
    Console.ResetColor();

    string path = Console.ReadLine();
    listNumbers.CreateFileTxt(path);
    Console.ReadLine();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}