Console.WriteLine("Wpisz wysokość drzewa (min 2, max 10): ");

int h = 1;

int mh = int.Parse(Console.ReadLine());
if (mh < 2)
{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie.");
        Console.ResetColor();
        Environment.Exit(0);
}
else if (mh > 10)
{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie.");
        Console.ResetColor();
        Environment.Exit(0);
}

for (; h <= mh; h++)
{
        for (int blanks = 0; blanks < mh - h; blanks++)
        {
                Console.Write(" ");
        }
        for (int stars = 0; stars < h * 2 - 1; stars++)
        {
                Console.Write("*");
        }
        Console.WriteLine();
}
for (int x = 0; x < mh - 1; x++)
{
        Console.Write(" ");
}
Console.Write("*");

/*
     *
    ***
   *****
  *******
 *********
***********
     *
*/