/*Console.WriteLine("Hello, World!\n I am Muhydeen");

var num = 10;
Console.WriteLine($"num is {num}\n");
num =8;

Console.WriteLine(CheckEven(num));

Console.WriteLine($"Now num is {num}");

//We are checking const here


 This is multiple line comment
 

const int num2 = 10;
//num2 = 8; // This will cause a compile-time error because num2 is a constant and cannot be reassigned.

if( num == num2)
{
    Console.WriteLine("Both numbers are equal\n");
}
else
{
    Console.WriteLine("Both numbers are not equal");
}
//Looping

while(num>0)
{
    Console.WriteLine("My name is Muhydeen");
    num--;
}
List<int> list = [2, 3, 4, 5, 6, 7];
foreach(var i in list)
{
    Console.WriteLine(i*3);
}

for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]*2);
    if(list[i]%2==0)
    {
        Console.WriteLine($"{list[i]} is even number");
    }
}

bool CheckEven(int n)
{
    return n % 2 == 0;
}
*/
// A method signature consists of the method name and its parameter list.
// The return type is not part of the method signature.
// Therefore, you cannot have two methods with the same name and parameter list, even if they have different return types.
// This is because the compiler would not be able to determine which method to call based on the arguments provided.


//int num = 10;
//string name = "Muhydeen";
using SQ03;

int[] arr = [34, 15, 88, 2];
//List<int> list = [1, 2, 3, 4, 5];

//list.Add(6);
//list.Remove(2);
//HashSet<int> set = new HashSet<int>();
//Stack<int> stack = new Stack<int>();
//Queue<int> queue = new Queue<int>();
//Dictionary<string, int> dict = new Dictionary<string, int>();
//KeyValuePair<string, int> kvp = new KeyValuePair<string, int>("key", 1);

Console.WriteLine(Car.FindSmallestInt(arr));

var bingo = new Dog
{
    Name = "Bingo",
    Age =4,
    NumberOfLegs =4,
    Breed = "Labrador",
    IsTrained = true
};

Animal myDog = new Dog();

bingo.ReturnAge();
bingo.ReturnAge(5);
bingo.ReturnAge(bingo.Name);

bingo.Age.ToString();