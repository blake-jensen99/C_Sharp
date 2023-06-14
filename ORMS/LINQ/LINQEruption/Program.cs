List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!
 
// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}


// QUERIES

Eruption? FirstChile = eruptions.FirstOrDefault(c => c.Location == "Chile");
Console.WriteLine(FirstChile.ToString());

Console.WriteLine("---------------------------------------------");

Console.WriteLine("---------------------------------------------");

Eruption? FirstHawaiian = eruptions.FirstOrDefault(c => c.Location == "Hawaiian Is");
if (FirstHawaiian != null)
{
    Console.WriteLine(FirstHawaiian.ToString());
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found");
}

Console.WriteLine("---------------------------------------------");

Eruption? FirstGreenland = eruptions.FirstOrDefault(c => c.Location == "Greenland Is");
if (FirstGreenland != null)
{
    Console.WriteLine(FirstGreenland.ToString());
}
else
{
    Console.WriteLine("No Greenland Is Eruption found");
}

Console.WriteLine("---------------------------------------------");

Eruption? First1900NZ = eruptions.Where(y => y.Year > 1900).FirstOrDefault(l => l.Location == "New Zealand");
Console.WriteLine(First1900NZ.ToString());

Console.WriteLine("---------------------------------------------");

List<Eruption> Over2000 = eruptions.Where(e => e.ElevationInMeters > 2000).ToList();
foreach (Eruption e in Over2000 )
{
    Console.WriteLine(e.ToString());
}

Console.WriteLine("---------------------------------------------");

List<Eruption> StartsWithL = eruptions.Where(n => n.Volcano[0] == 'L').ToList();
foreach (Eruption e in StartsWithL)
{
    Console.WriteLine(e.ToString());
}
Console.WriteLine($"{StartsWithL.Count} eruptions found.");

Console.WriteLine("---------------------------------------------");

int MaxEl = eruptions.Max(eruptions => eruptions.ElevationInMeters);
Console.WriteLine(MaxEl);

Console.WriteLine("---------------------------------------------");

Eruption? MaxElName = eruptions.FirstOrDefault(e => e.ElevationInMeters == MaxEl);
Console.WriteLine(MaxElName.Volcano);

Console.WriteLine("---------------------------------------------");

List<Eruption> Alphabetically = eruptions.OrderBy(n => n.Volcano).ToList();
foreach (Eruption e in Alphabetically)
{
    Console.WriteLine(e.ToString());
}

Console.WriteLine("---------------------------------------------");

int Sum = eruptions.Sum(e => e.ElevationInMeters);
Console.WriteLine(Sum);

Console.WriteLine("---------------------------------------------");

bool Year200 = eruptions.Any(e => e.Year == 2000);
Console.WriteLine(Year200);

Console.WriteLine("---------------------------------------------");

List<Eruption> ThreeStrat = eruptions.Where(e => e.Type == "Stratovolcano").Take(3).ToList();
foreach (Eruption e in ThreeStrat)
{
    Console.WriteLine(e.ToString());
}

Console.WriteLine("---------------------------------------------");

List<Eruption> Before1000Alph = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).ToList();
foreach (Eruption e in Before1000Alph)
{
    Console.WriteLine(e.ToString());
}

Console.WriteLine("---------------------------------------------");

List<string> Before1000AlphNames = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano).ToList();
foreach (string e in Before1000AlphNames)
{
    Console.WriteLine(e);
}