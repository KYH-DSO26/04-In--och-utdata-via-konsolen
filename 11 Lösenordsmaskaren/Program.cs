Console.Write("Ange ditt lösenord: ");
string lösenord = "";
while (true)
{
    var tangent = Console.ReadKey(intercept: true); // intercept: true gör att tecknet inte visas i konsolen
    if (tangent.Key == ConsoleKey.Enter) break; // Avsluta loopen om Enter trycks

    else if (tangent.Key == ConsoleKey.Backspace)
    {
        if (lösenord.Length > 0)
        {
            lösenord = lösenord.Substring(0, lösenord.Length - 1);
            Console.Write("\b \b"); // Tar bort det sista tecknet från konsolen)
        }
    }
    else
    {
        lösenord += tangent.KeyChar; // Lägg till tecknet i lösenordet
        Console.Write("*"); // Visa en asterisk istället för tecknet
    }
}

Console.WriteLine($"\nLösenordet har sparats säkert!");
Console.WriteLine($"Lösenordet du angav:\t {lösenord}");






Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
