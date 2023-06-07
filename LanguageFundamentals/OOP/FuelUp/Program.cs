Horse Roach = new Horse("Roach", "Brown", "Apples");
Car McQueen = new Car("Lightning McQueen", "Red", "Gas", 0);
Bicycle Pelaton = new Bicycle("Pelaton", "Black");


Roach.ShowInfo();
McQueen.ShowInfo();
Pelaton.ShowInfo();


// Ride Test = new Ride("Test", "Blue");
// Doesn't work since the Ride class is abstract

List<Ride> rides = new List<Ride> {Roach, McQueen, Pelaton};


List<INeedFuel> FuelPowered = new List<INeedFuel> ();


foreach (Ride r in rides) 
{
    if (r is INeedFuel) {
        Console.WriteLine(r);
        FuelPowered.Add((INeedFuel)r);
    }
}

foreach (INeedFuel f in FuelPowered) 
{
    f.GiveFuel(10);
}


foreach (INeedFuel f in FuelPowered) 
{
    Console.WriteLine($"{f.Name} has {f.FuelTotal} fuel.");
}

