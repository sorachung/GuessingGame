using System;

int secretNumber = 42;
int guessesLeft = 4;
int guessNumber = 1;

while (guessNumber <= guessesLeft)
{
    Console.WriteLine($"Your guess - {guessNumber}");
    Console.Write("Please guess the Secret Number: ");
    string guess = Console.ReadLine();

    if (int.Parse(guess) == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed correctly!");
        break;
    }
    else
    {
        Console.WriteLine("You are WRONG!");
    }
    guessNumber++;

}
