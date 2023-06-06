class Enemy 
{
    public string Name;
    private int Health = 100;
    public int _Health 
    {
        get 
        {
            return Health; 
        }
    }
    public List<Attack> AttackList = new List<Attack>();

    public Enemy(string n)
    {
        Name = n;
    }

    public void AddAttack(Attack attack) 
    {
        AttackList.Add(attack);
        Console.WriteLine($"Enemy has learned {attack.Name}");
    }

    public void RandomAttack() 
    {
        Random rand = new Random();
        int idx = rand.Next(AttackList.Count);
        Console.WriteLine($"Enemy randomly attacked with {AttackList[idx].Name}, dealing {AttackList[idx].Damage}");
    }
}