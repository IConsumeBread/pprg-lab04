int LiczbaTur = 0;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    string tekst = Console.ReadLine();

    bool czyLiczba = int.TryParse(tekst, out LiczbaTur);

    if (czyLiczba == false)
    {
        Console.WriteLine("Podaj liczbę całkowitą.");
        continue;
    }

    if (LiczbaTur < 1 || LiczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1-10");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam gre na {LiczbaTur} tur.");

for (int i = 1; i <= LiczbaTur; i++)
{
    Console.WriteLine($"Tura {i}");
}
