bool restart = true;
do
{
    Console.Write("Please enter a number: ");
    int num = int.Parse(Console.ReadLine());

    bool restart2 = true;
    if (num >= 1 && num <= 1290)
    {
        int sq = 1;
        int cu = 1;
        Console.WriteLine("" +
                "Number\t\tSquared\t\tCubed\n" +
                "=======\t\t=======\t\t=======");
        for (int x = 1; x <= num; x++)
        {
            sq = x * x;
            cu = x * x * x;
            Console.WriteLine("{0,7}\t\t{1,7}\t\t{2,7}", x, sq, cu);
        }
        Console.WriteLine("Would you like to enter another number?");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y" || choice == "yes")
        {
            restart = true;
        }
        else
        {
            restart = false;
        }
    }
    else
    {
        Console.WriteLine("Invald entry..");
    }
} while (restart == true);
Console.WriteLine("Goodbye!");