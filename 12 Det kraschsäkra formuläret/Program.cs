double giltigtFlyttal = 0;
bool godkändInmatning = false;
while (!godkändInmatning)
{
    Console.Write("Mata in ett flyttal (t.ex. 12,34): ");
    string indata = Console.ReadLine();
    if (double.TryParse(indata, out giltigtFlyttal))
    {
        godkändInmatning = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt format! Försök igen.");
        Console.ResetColor();
    }
}
Console.WriteLine($"Tack! Talet {giltigtFlyttal} sparades utan krasch.");




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
