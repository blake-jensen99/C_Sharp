

class Dog
{
    private string Name;
    public string _Name
    {
        get
        {
            return Name;
        }
        set{
            if (value == "Jakers")
            {
                Name = value;
            }
        }
    }
    public string Breed;
    public string FurColor;

    public Dog( string n, string b, string f) 
    {
        Name = n;
        Breed = b;
        FurColor = f;
    }

    public void Bark()
    {
        Console.WriteLine("Bark! Bark!");
    }

    public void Fetch(string Item)
    {
        Console.WriteLine($"{Name} hurries to fetch the {Item}!");
    }
}

