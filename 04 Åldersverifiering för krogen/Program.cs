Console.Write("Mata in din ålder: ");
string inmatning = Console.ReadLine();
//int ålder = int.Parse(inmatning);
bool ålderOk = int.TryParse(inmatning, out int ålder);
Console.WriteLine($"int.TryParse resultat: {ålderOk}, ålder: {ålder}");
if (ålder >= 18)
{
    Console.WriteLine("Välkommen in!");
}
else if(ålder < 0)
{
    Console.WriteLine("Ogiltig ålder.");
}
else
{
    Console.WriteLine("Tyvärr, du är för ung.");
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();
