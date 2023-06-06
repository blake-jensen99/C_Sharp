public class Magic : Enemy
{
    public Attack Fireball = new Attack("Fireball", 25);
    public Attack Lightning = new Attack("Lightning Bolt", 20);
    public Attack Staff = new Attack("Staff Strike", 10);

    public Magic(string n) : base (n, 80)
    {
        AttackList = new List<Attack> {Fireball, Lightning, Staff};
    }

    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        if (Target.Health > 100){
            Target.Health = 100;
        }
        Console.WriteLine($"{Name} healed {Target.Name} for 40. Bringing them to {Target.Health} health!");
    }
}