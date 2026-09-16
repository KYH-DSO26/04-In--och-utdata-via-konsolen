int valdMenyPunkt = 1;
Console.WriteLine("Använd piltangenterna (Upp/Ned) och tryck sedan på Enter:\n\n"); // Raderas vid Console.Clear()...

while (true)
{
    Console.Clear();
    Console.WriteLine(valdMenyPunkt == 1 ? "> Starta spelet" : "  Starta spelet");
    Console.WriteLine(valdMenyPunkt == 2 ? "> Inställningar" : "  Inställningar");
    Console.WriteLine(valdMenyPunkt == 3 ? "> Avsluta" : "  Avsluta");

    var knapp = Console.ReadKey(true);
    if (knapp.Key == ConsoleKey.DownArrow && valdMenyPunkt < 3) valdMenyPunkt++;
    else if (knapp.Key == ConsoleKey.UpArrow && valdMenyPunkt > 1) valdMenyPunkt--;
    else if (knapp.Key == ConsoleKey.Enter) break;
}

Console.WriteLine($"\nDu valde alternativ {valdMenyPunkt}");








Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
