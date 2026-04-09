var num = 0;

Greeting(out  num);
if(num == 0)
{
    Greeting(out num);
}





void Greeting(out int num)
{
    Console.WriteLine("Welcome to my personal manager\nPlease choose any of the following options:\n1. Add a new contact\n2. View contacts\n3. Exit");
    var input = Console.ReadLine();

    var isNumber = int.TryParse(input, out int ourNum);
    if(!isNumber)
    {
        Console.WriteLine("The input entered is not a number, please try again");
    }
    else
    {
        if (ourNum < 1 || ourNum > 3)
        {
            Console.WriteLine("The input entered is not within the expected value range, please try again");
        }
    }
    num = ourNum;
}

