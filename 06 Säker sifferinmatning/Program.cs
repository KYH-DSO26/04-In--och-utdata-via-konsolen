Console.Write("Mata in ett heltal: ");
string inmatning = Console.ReadLine();

if (int.TryParse(inmatning, out int resultat))
{
    Console.WriteLine($"Snyggt: Du matade in talet: {resultat}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{inmatning} är inget giltigt heltal");
    Console.ResetColor();   // Återställ färger
}




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
