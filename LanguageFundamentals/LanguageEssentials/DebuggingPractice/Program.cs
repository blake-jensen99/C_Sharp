// Challenge 1
bool amProgrammer = true;
// booleans aren't strings
double Age = 27.9;
// numbers with decimals are declared with double
List<string> Names = new List<string>();
Names.Add("Monica");
// Have to Add the value instead
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// value must be string as well due to delcaration 
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";
// ' ' is for a single character, " " is for strings




// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--)
{
    Console.WriteLine(Numbers[i]);
}
// i cannot equal Numbers.Count since it is out of range




// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}
// foreach loops doesn't use indexes. It goes straight through the values




// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
// foreach(int num in EvenMoreNumbers)
// {
//     if(num % 3 == 0)
//     {
//         num = 0;
//     }
// }
// altering values within a foreach is not possible because this method of looping is for reading only, not modifing
for (int i = 0; i < EvenMoreNumbers.Count; i++) {
    if (EvenMoreNumbers[i] % 3 == 0) {
        EvenMoreNumbers[i] = 0;
    }
}
// a normal for loop could be used to accomplish this


// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p";
// strings are read-only 
// one way this can be done is by turning the string into a char array, changing the value at the given index, and then changing it back into a string
char[] split = MyString.ToCharArray();
split[7] = 'p';
MyString = new string(split);
Console.WriteLine(MyString);





// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
// the ending point for .Next is exclusive, so to give the if statement a chance to run, we have to change the arguement to at least 13

