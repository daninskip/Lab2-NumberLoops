//Hello World
bool tryAgain = true;

do
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Would you like to continue (y/n)");

    string tryAgainInput = Console.ReadLine();
    tryAgain = tryAgainInput.ToLower() == "y";

} while (tryAgain == true);
Console.WriteLine("Goodbye!");

//Number Loop
bool goAgain = true;

while (goAgain)
{
    Console.WriteLine("Please enter a number");

    int numberInput;
    bool isValid = int.TryParse(Console.ReadLine(), out numberInput);
    while (!isValid)
    {
        Console.WriteLine("Please enter a valid number");
        isValid = int.TryParse(Console.ReadLine(), out numberInput);
    }

    for (int i = numberInput; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int i = 0; i <= numberInput; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Would you like to continue (y/n)?");
    string goAgainInput = Console.ReadLine();
    goAgain = goAgainInput.ToLower() == "y";

}
Console.WriteLine("Thankyou for playing. Goodbye");
Environment.Exit(0);

//Key Pad Entry Part 1
bool doorLocked = true;

int doorCombination = 13579;
int attemptLimit = 5;

while (doorLocked)
{
    int attemptNumber = 1;
    while (attemptNumber <= attemptLimit)
    {
        Console.WriteLine("Please enter door combination");
        int combinationInput;
        bool isvalid = int.TryParse(Console.ReadLine(), out combinationInput);
        if (isvalid)
        {
            if (combinationInput == doorCombination)
            {
                doorLocked = false;
                Console.WriteLine("Correct combination, welcome home");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect code. You have " + (attemptLimit - attemptNumber) + " attempts remaining");
                attemptNumber++;
            }
        }
    }
    Console.WriteLine("Too many incorrect attempts. Goodbye");
    Environment.Exit(0);
}

//Keypad Entry Pt 2 + Optional Stretch

do
{
    CheckCombination();
} while (doorLocked);


void CheckCombination()
{
    int attemptNumber = 1;
    do
    {
        Console.WriteLine("Please enter door combination");
        int combinationInput;
        bool isvalid = int.TryParse(Console.ReadLine(), out combinationInput);
        if (isvalid)
        {
            if (combinationInput == doorCombination)
            {
                doorLocked = false;
                Console.WriteLine("Correct combination, welcome home");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Incorrect code. You have " + (attemptLimit - attemptNumber) + " attempts remaining");
                attemptNumber++;
            }
        }

    } while (attemptNumber <= attemptLimit);
    Console.WriteLine("Too many incorrect attempts. Goodbye");
    Environment.Exit(0);
}

