using System;

Console.WriteLine(@"Please choose a difficulty level:
1) Easy
2) Medium
3) Hard
4) Cheater");

string difficultyChoice = Console.ReadLine();
int guessesLeft;
bool cheater = false;
switch (difficultyChoice)
{
    case "1":
        guessesLeft = 8;
        break;
    case "2":
        guessesLeft = 6;
        break;
    case "3":
        guessesLeft = 4;
        break;
    case "4":
        guessesLeft = 0;
        cheater = true;
        break;
    default:
        guessesLeft = 1;
        break;
}

int secretNumber = new Random().Next(1, 101);
int guessNumber = 1;

while (guessNumber <= guessesLeft || cheater)
{
    if (!cheater)
    {
        if (guessesLeft - guessNumber + 1 == 1)
        {
            Console.WriteLine($"You have 1 guess left.");
        }
        else
        {
            Console.WriteLine($"You have {guessesLeft - guessNumber + 1} guesses left.");
        }
    }
    else
    {
        Console.WriteLine("You have infinite guesses left.");
    }
    Console.Write("Please guess the Secret Number between 1 and 100: ");
    int guess;
    bool success = int.TryParse(Console.ReadLine(), out guess);
    while (!success)
    {
        Console.Write("Please input a number: ");
        success = int.TryParse(Console.ReadLine(), out guess);
    }

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
    }
    guessNumber++;

}

Console.WriteLine("End Game");