Enemy Pirate = new Enemy("Pirate");

Attack Sword = new Attack("Sword", 10);
Attack Flintlock = new Attack("Flintlock Pistol", 15);
Attack Cannon = new Attack("Cannon", 25);

Pirate.AddAttack(Sword); 
Pirate.AddAttack(Flintlock); 
Pirate.AddAttack(Cannon); 
// Pirate.AttackList.Add(Sword);
// Console.WriteLine(string.Join(", ", Pirate.AttackList)); 
foreach (Attack item in Pirate.AttackList) 
{
    // Console.WriteLine(item.Name);
}

Pirate.RandomAttack();
 