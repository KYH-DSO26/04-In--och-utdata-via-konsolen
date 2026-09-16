//Console.Write("Tryck på en valfri tangent: ");
//ConsoleKeyInfo tangentInfo = Console.ReadKey(false);

//Console.WriteLine($"\nDu tryckte på: {tangentInfo.KeyChar} (Tangentkod: {tangentInfo.Key})");

// Exempelkod från Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-10.0
ConsoleKeyInfo cki;
// Prevent example from ending if CTL+C is pressed.
Console.TreatControlCAsInput = true;

Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
Console.WriteLine("Press the Escape (Esc) key to quit: \n");
do
{
    cki = Console.ReadKey();
    Console.Write(" --- You pressed ");
    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
    if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
    Console.WriteLine(cki.Key.ToString());
} while (cki.Key != ConsoleKey.Escape);


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
