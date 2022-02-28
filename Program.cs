using System;

int secretNumber = 42;
int guessesLeft = 4;

while (guessesLeft > 0)
{
    Console.Write("Please guess the Secret Number: ");
    string guess = Console.ReadLine();

    if (int.Parse(guess) == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed correctly!");
    }
    else
    {
        Console.WriteLine("You are WRONG!");
    }
    guessesLeft--;
}
