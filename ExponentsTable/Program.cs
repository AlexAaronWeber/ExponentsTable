//Main
Console.WriteLine("Learn your squares and cubes!");

bool runTable = true;
while (runTable)
{
    int userNum = 0;

    while (true)
    {
        Console.WriteLine("Enter a positive integer");
        userNum = int.Parse(Console.ReadLine());

        if (userNum > 0 && userNum <= 1290)
        {
            break; 
        }
        else
        {
            Console.WriteLine($"{userNum} just won't work.");
        }
    }

    Console.WriteLine(String.Format("{0,6}{1,15}{2,15}" ,"Number","Squared" ,"Cubed"));
    Console.WriteLine(String.Format("{0,6}{1,15}{2,15}" ,"======","=======","====="));

    for (int i = 1; i <= userNum; i++)
    {
       Console.WriteLine(String.Format("{0,6}{1,15}{2,15}", i ,  ToSquare(i) , ToCube(i)));
    }

    while (true)
    {
        Console.WriteLine("Try another number? y/n");
        string loopChoice = Console.ReadLine();

        if (loopChoice.ToLower().Trim() == "y")
        {
            runTable = true;
            break;
        }
        else if (loopChoice.ToLower().Trim() == "n")
        {
            runTable = false;
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid choice");
        }
    }
}

//Methods

//squared
static int ToSquare(int x)
{
    return x * x;
}

//cubed
static int ToCube(int x)
{
    return x * x * x;
}
