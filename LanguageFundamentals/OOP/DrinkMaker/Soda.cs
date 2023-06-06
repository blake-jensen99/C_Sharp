public class Soda : Drink
{
    public bool Diet;

    public Soda(bool diet, string name, string color, double temp, int calories) : base(name, color, temp, true,  calories) 
    {
        Diet = diet;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet: {Diet}");
    }
}