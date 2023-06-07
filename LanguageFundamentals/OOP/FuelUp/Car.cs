public class Car : Ride, INeedFuel
{

    public string FuelType {get;set;}
    public int FuelTotal {get;set;}

    public Car(string n, string c, string fty, int p = 1,  int ftt = 10) : base (n, c, p, true)
    {
        FuelType = fty;
        FuelTotal = ftt;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Fuel Type: {FuelType}, Fuel Total: {FuelTotal}");
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        Console.WriteLine($"You gave {Name} {Amount} {FuelType}.");
    }
}