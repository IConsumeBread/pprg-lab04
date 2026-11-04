int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool maMikstury = liczbaMikstur > 0;
bool ucieczka = false;
bool poprawnaAkcja = false;

while (zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0 && ucieczka == false){
Console.WriteLine($"Numer tury: {numerTury}");
Console.WriteLine($"Twoje zdrowie: {zdrowieBohatera}");
Console.WriteLine($"Zdrowie przeciwnika: {zdrowiePrzeciwnika}");

Console.WriteLine("");
Console.Write("Wybierz akcje (1-3): ");
int akcja = int.Parse(Console.ReadLine());

switch (akcja)
{
    case 1:
        poprawnaAkcja = true;
        zdrowiePrzeciwnika -= 12;
        Console.WriteLine("Bohater zadaje 12 punktów obrażeń.");
    break;

    case 2:
    if (liczbaMikstur <= 0)
        {
            Console.WriteLine("Nie możesz się leczyć, nie masz mikstur.");
        }
        else
        {
            poprawnaAkcja = true;
            liczbaMikstur --;
            zdrowieBohatera += 15;
            Console.WriteLine($"Użyłeś miksturę!\nTwoje zdrowie: {zdrowieBohatera}\nLiczba mikstur: {liczbaMikstur}");   
        }
    break;

    case 3:
        Console.ForegroundColor = ConsoleColor.Yellow;
        ucieczka = true;
        Console.WriteLine("Bohater ucieka.");
        Console.ResetColor();
    break;

    default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Akcja nie istnieje.");
        Console.ResetColor();
    break;
}

if (ucieczka)
    {
        break;
    }
    
if (zdrowiePrzeciwnika <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zwycięstwo!");
        Console.ResetColor();
        break;
    }

if (poprawnaAkcja)
    {
        zdrowieBohatera -= 7;
        Console.WriteLine("Przeciwnik zadaje 7 punktów obrażeń.");
        numerTury ++;

    if (zdrowieBohatera <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Porażka. D:");
            Console.ResetColor();
            break;
        }
    }
}
