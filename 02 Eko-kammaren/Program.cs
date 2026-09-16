Console.Write("Skriv in ett meddelande: ");
string meddelande = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Eko: {meddelande}");

Console.ResetColor();   // Återställ färger




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
