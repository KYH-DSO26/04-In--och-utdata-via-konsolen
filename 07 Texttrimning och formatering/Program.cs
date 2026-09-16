Console.Write("Skriv in ditt förnamn (gärna med extra mellanslag före eller efter): ");
string råInmatning = Console.ReadLine();
string inmatning = råInmatning.Trim(); // Tar bort mellanslag före och efter

Console.WriteLine($"Hej [{inmatning}]! Din inmatning var {råInmatning.Length} tecken, men namnet är egentligen {inmatning.Length} tecken långt.");




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
