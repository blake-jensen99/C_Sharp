// ARRAYS

int[] nums = {1,2,3,4};
foreach (int num in nums) {
    // Console.WriteLine(num);
}

string[] test = {"test", "test2", "test3", "test4"};

for (int i = 0; i < test.Length; i++) {
    // Console.WriteLine($"This is {test[i]}");
}

int[] eight = new int[8];

eight[2] = 17;

// ARRAYS

// LISTS

List<string> tests = new List<string> {"test", "test2", "test3", "test4"};
foreach (string value in tests) {
    // Console.WriteLine(value);
}
tests.Add("test100");
tests.Remove("test");
// Console.WriteLine(string.Join(", ", tests));
tests.Reverse();
// Console.WriteLine(string.Join(", ", tests));

// LISTS 

// DICTIONARIES

Dictionary<string, int> ages = new Dictionary<string, int>();

ages.Add("Tod", 42);
ages.Add("Rudy", 25);
ages.Add("Andrew", 76);

// Console.WriteLine(string.Join(", ", ages));

foreach (var item in ages)
{
    // Console.WriteLine(item.Key + ": " + item.Value);
}

ages.Remove("Tod");
// Console.WriteLine(string.Join(", ", ages));

// Console.WriteLine(ages["Rudy"]);

// DICTIONARIES

// FUNCTIONS

static void SayHello() {
    Console.WriteLine("Hello how are you doing today?");
}
SayHello();

static double DivideTwo(int a, int b) {
    return a/b;
}

Console.WriteLine(DivideTwo(234568352,235235));

// FUNCTIONS

Random rand = new Random();
rand.Next(0, 2);
