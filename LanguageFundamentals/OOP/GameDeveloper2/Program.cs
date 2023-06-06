Melee Gimli = new Melee("Gimli");
Ranged Legolas = new Ranged("Legolas");
Magic Gandalf = new Magic("Gandalf");

Gimli.PerformAttack(Legolas, Gimli.Kick);
Gimli.Rage(Gandalf);
Legolas.PerformAttack(Gimli, Legolas.Arrow);
Legolas.Dash();
Legolas.PerformAttack(Gimli, Legolas.Arrow);
Gandalf.PerformAttack(Gimli, Gandalf.Fireball);
Gandalf.PerformAttack(Gimli, Gandalf.Fireball);
Gandalf.PerformAttack(Gimli, Gandalf.Fireball);
Gandalf.PerformAttack(Gimli, Gandalf.Fireball);
Gandalf.PerformAttack(Gimli, Gandalf.Fireball);
Gandalf.Heal(Legolas);
Gandalf.Heal(Gandalf);
Gandalf.Heal(Gandalf);