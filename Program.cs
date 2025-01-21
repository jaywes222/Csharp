string rocket = ("     |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|");

int landingHeight = 10;

for (int i = 0; i < landingHeight; i++)
{
    Console.Clear();

    Console.WriteLine($"Rocket Landing in: {landingHeight - i} seconds");

    for (int j = 0; j < i; j++)
    {
        Console.WriteLine();
    }
    Console.WriteLine(rocket);

    Thread.Sleep(800);
}
Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");

Console.ReadKey();
