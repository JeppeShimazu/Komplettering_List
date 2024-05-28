// Person 1 skriver in ordet
Console.WriteLine("Hej, välkommen till hänga gubbe! Var snäll skriv in ett ord som du vill att de andra ska gissa på:");
// Bara små bokstäver
string GömtOrd = Console.ReadLine().ToLower();
List<char> gissadeBokstäver = new List<char>();
int maxGissningar = 6;
int Gissningar = 0;

// Person 2 ska spela
while (true)
{
Console.Clear();
Console.WriteLine("Gissa ordet:");

bool Gissade = true;
foreach (char c in GömtOrd)
{
if (gissadeBokstäver.Contains(c))
{
    Console.Write(c + " ");
}
//Skriver ut ordet i _
else
{
    Console.Write("_ ");
    Gissade = false;
}
}

Console.WriteLine();

// Vinst
if (Gissade)
{
    System.Console.WriteLine("Ordet var: " + GömtOrd);
    Console.WriteLine("Grattis! Du har gissat ordet!");
    Console.ReadLine();
    break;
}

// Förlust
if (Gissningar >= maxGissningar)
{
    Console.WriteLine("Du har förlorat. Ordet var: " + GömtOrd);
    Console.ReadLine();
    break;
}

// gissa bokstav
Console.Write("Gissa en bokstav: ");
char gissning = Console.ReadLine().ToLower()[0];

// Är bokstaven redan är gissad?
if (gissadeBokstäver.Contains(gissning))
{
    Console.WriteLine("Du har redan gissat den bokstaven. Försök igen.");
    Console.ReadLine(); // Väntar på att användaren trycker en tangent
}

// Lägg till bokstaven i listan
gissadeBokstäver.Add(gissning);

// Finns bokstaven i ordet?
if (!GömtOrd.Contains(gissning))
{
    Gissningar++;
    Console.WriteLine($"Fel! Du har {maxGissningar - Gissningar} försök kvar.");
    Console.ReadLine();
}
}