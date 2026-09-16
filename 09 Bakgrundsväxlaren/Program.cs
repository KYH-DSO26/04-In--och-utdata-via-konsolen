Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();   // Rensa konsolfönstret

Console.WriteLine("Nu kör vi med blå bakgrund och vit text!");
Console.ResetColor();   // Återställ färger
Console.BackgroundColor = ConsoleColor.Black;



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
