Console.WriteLine("Hej och välkommen till hälsningsmaskinen!");
Console.Write("Vad heter du? ");
string namn = Console.ReadLine();

Console.Write("Vilken stad bor du i? ");
string stad = Console.ReadLine();

Console.WriteLine($"Hej {namn}! Hur är vädret i {stad}?");




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
