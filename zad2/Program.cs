Console.Write("Podaj licbę dni: ");
int dayAmount = int.Parse(Console.ReadLine());
int totalGold = 0;
int funnyGold = 0;
for (int day = 1; day <= dayAmount; day++)
{
    Console.Write($"Podaj ile złota znaleziono w dniu {day}: ");
    int goldFound = int.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"W dniu {day} znaleziono {goldFound} złota");
    Console.ResetColor();
    if (goldFound > 10)
    {
        funnyGold++;
    }
    totalGold += goldFound;
}

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"\nŁącznie znaleziono: {totalGold}");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Dni z wynikiem > 10: {funnyGold}");
Console.ResetColor();