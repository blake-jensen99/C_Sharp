public class Coffee : Drink
{
    public string Roast;
    public string BeanType;

    public Coffee(string roast, string beanType, string name, string color, double temp, int calories) : base(name, color, temp, false,  calories) 
    {
        Roast = roast;
        BeanType = beanType;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast: {Roast}");
        Console.WriteLine($"BeanType: {BeanType}");
    }
}