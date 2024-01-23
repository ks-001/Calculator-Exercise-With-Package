using StringMath;

Console.WriteLine("---Calculator---");
bool stopRunning = false;

while (!stopRunning)
{
    Console.WriteLine("Enter an expression: ");
 
    string input = Console.ReadLine();

    string inputWithoutSpaces = input.Replace(" ", "");

    if (inputWithoutSpaces.Contains("/0"))
    {
        Console.WriteLine("Error: cannot divide by zero.");
        continue;
    }

    try
    {
        double result = input.Eval();

        Console.WriteLine(result.ToString());

    }
    
    catch (Exception ex)
    {
        Console.WriteLine("The expression you entered wasn't valid");
    }
    
    finally
    {
        Console.WriteLine("Press x then Enter to exit, or Enter on its own to continue");
        
        if (Console.ReadLine() == "x")
        {
            stopRunning = true;
        }
    }
}
