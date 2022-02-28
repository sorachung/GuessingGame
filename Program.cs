using System;

int secretNumber = new Random().Next(1, 101);
int guessesLeft = 4;
int guessNumber = 1;

while (guessNumber <= guessesLeft)
{
    Console.WriteLine($"Your guess - {guessNumber}");
    Console.Write("Please guess the Secret Number: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("Congratulations! You guessed correctly!");
        break;
    }
    else
    {
        if (guess > secretNumber)
        {
            Console.WriteLine("You guessed too HIGH!");
        }
        else if (guess < secretNumber)
        {
            Console.WriteLine("You guessed too LOW!");
        }
        if (guessesLeft - guessNumber == 1)
        {
            Console.WriteLine($"You have 1 guess left.");
        }
        else
        {
            Console.WriteLine($"You have {guessesLeft - guessNumber} guesses left.");
        }
    }
    guessNumber++;

}
