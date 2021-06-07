private static int GetGuess()
{
    int guess = 0;
    try
    {
        guess = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Capture user input appropriately.");
        guess = GetGuess();
    }
    return guess;
}
int allowedTries = 5;
int numberOfTries = 0;
 
while (true)
{
    int guess = GetGuess();
    numberOfTries++;
    if (guess == randomNumber)
    {
        Console.WriteLine("Win! 100 points");
        break;
    }
    if (guess > randomNumber)
    {
        Console.WriteLine("Lose! 0 points");
    }
    if (guess < randomNumber)
    {
        Console.WriteLine("33 points, Try Again");
    }
    if (numberOfTries == allowedTries)
    {
        Console.WriteLine($"The number was: {randomNumber}");
        break;
    }
    Console.Write($"You have {allowedTries - numberOfTries} tries left. Enter another number: ");
}