public class Ranged : Enemy
{
    public int Distance;
    public Attack Arrow = new Attack("Shoot Arrow", 20);
    public Attack Knife = new Attack("Throw a Knife", 15);

    public Ranged(string n, int d = 5) : base (n)
    {
        Distance = d;
        AttackList = new List<Attack> {Arrow, Knife};
    }


    public void Dash() 
    {
        Distance = 20;
        Console.WriteLine($"{Name} dashed to a distance of 20 from their targets.");
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance >= 10)
        {
            base.PerformAttack(Target, ChosenAttack);
        }
        else 
        {
            Console.WriteLine($"{Name} is too close to target. Move back!");
        }
    }
}