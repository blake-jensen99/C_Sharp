int[] numArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

string[] names = {"Tim", "Martin", "Nikki", "Sara"};

bool[] tF = new bool[10];

for (int i = 0; i < tF.Length; i++) {
    if (i % 2 != 0) {
        tF[i] = false;
    }
    else {
        tF[i] = true;
    }
}

Console.WriteLine(string.Join(", ", tF));


// -----------------------------------------


List<string> flavors = new List<string> {"Vanilla", "Chocolate", "Mint Chip", "Cookie Dough", "Cookies and Cream", "Strawberry"};

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count);


// -----------------------------------------

Random rand = new Random();

Dictionary<string, string> users = new Dictionary<string, string>();

foreach (string name in names) {
    users.Add(name, flavors[rand.Next(0, flavors.Count)]);
}

foreach (var item in users)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}
