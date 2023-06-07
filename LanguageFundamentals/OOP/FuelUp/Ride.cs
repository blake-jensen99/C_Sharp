public abstract class Ride
{
    public string Name {get;set;}
    int NumOfPass {get;set;}
    string Color {get;set;}
    bool HasEngine {get;set;}
    int NumOfMiles = 0;

    public Ride(string n, string c, int p = 4,  bool e = true)
    {
        Name = n;
        NumOfPass = p;
        Color = c;
        HasEngine = e;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}, Number of Passengers: {NumOfPass}, Has an engine: {HasEngine}, Number of Miles: {NumOfMiles}");
    }

    public void Drive(int num){
        NumOfMiles += num;
        Console.WriteLine($"You drove {num} miles!");
    }
}