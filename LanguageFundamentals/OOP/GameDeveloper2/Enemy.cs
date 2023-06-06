public class Enemy
{
    public string Name;
    public int Health;
    public int _Health
    {
        get
        {
            return Health;
        }
    }
    public List<Attack> AttackList = new List<Attack>();

    public Enemy(string n, int health = 100)
    {
        Name = n;
        Health = health;
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

    // Inside of the Enemy class
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Target.Health > 0)
        {
            Target.Health = Target.Health - ChosenAttack.Damage;
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.Damage} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
        else 
        {
            Console.WriteLine($"{Target.Name} is already out of health, leave them alone.");
        }
    }


}