Random rand = new Random();

string CoinFlip() {
    if (rand.Next(2) == 0) {
        return "heads";
    }
    else {
        return "tails";
    }
}

// Console.WriteLine(CoinFlip());  


int DieRoll(int num = 20) {
    return rand.Next(num + 1);
}

// Console.WriteLine(DieRoll(100));


List<int> StatRoll(int num = 4) {
    List<int> rolls = new();
    for (int i = 0; i < num; i++) {
        rolls.Add(rand.Next(21));
    }
    Console.WriteLine($"Max: {rolls.Max()}"); 
    return rolls;
}

// Console.WriteLine(string.Join(", ", StatRoll(6)));



int counter = 0;
string RollUntil(int sides, int num) {
    if (rand.Next(1, sides + 1) == num) {
        counter += 1;
        return $"Rolled a {num} after {counter} tries";
    }
    else {
        counter += 1;
        return RollUntil(sides, num);
    }
}

// Console.WriteLine(RollUntil(3));


string InteractiveRoller() {
    Console.WriteLine("Choose how many sides your dice has:");
    string Input = Console.ReadLine();
    int sides = Convert.ToInt32(Input);
    Console.WriteLine("What is your desired outcome?");
    string Outcome = Console.ReadLine();
    int num = Convert.ToInt32(Outcome);
    return RollUntil(sides, num);
}

Console.WriteLine(InteractiveRoller()); 