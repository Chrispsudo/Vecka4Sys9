// See https://aka.ms/new-console-template for more information

Console.WriteLine("Skriv in tre stycken heltal mellan 1-7");
Console.WriteLine("Skriv in första talet");
int tal1 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in andra talet");
int tal2 = int.Parse(Console.ReadLine());

Console.WriteLine("Skriv in tredje talet");
int tal3 = int.Parse(Console.ReadLine());

if (tal1 < 1 || tal1 > 7 || tal2 < 1 || tal2 > 7 || tal3 < 1 || tal3 > 7)
{
    Console.WriteLine("Du måste skriva in tal mellan 1-7");
}
else if (tal1 < tal2 && tal1 < tal3)
{
    Console.WriteLine("Det minsta talet är: " + tal1);
}
else if (tal2 < tal1 && tal2 < tal3)
{
    Console.WriteLine("Det minsta talet är: " + tal2);
}
else if (tal3 < tal1 && tal3 < tal2)
{
    Console.WriteLine("Det minsta talet är: " + tal3);
}
Console.ReadLine();


