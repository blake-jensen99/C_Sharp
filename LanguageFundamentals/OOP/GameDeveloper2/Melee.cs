public class Melee : Enemy
{
    public Attack Punch = new Attack("Punch", 20);
    public Attack Kick = new Attack("Kick", 15);
    public Attack Tackle = new Attack("Tackle", 25);



    public Melee(string n) : base (n, 120)
    {
        AttackList = new List<Attack> {Punch, Kick, Tackle};
    }

    public void Rage(Enemy Target)
    {
        Random rand = new Random();
        int num = rand.Next(AttackList.Count);
        Target.Health = Target.Health - (AttackList[num].Damage + 10);
        Console.WriteLine($"{Name} entered a rage and attacked {Target.Name} with a {AttackList[num].Name} for {AttackList[num].Damage} damage! This leaves {Target.Name} with {Target.Health} health.");
    } 
}