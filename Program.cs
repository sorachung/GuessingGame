using System;

Console.WriteLine(@"Please choose a difficulty level:
1) Easy
2) Medium
3) Hard");

string difficultyChoice = Console.ReadLine();
int guessesLeft;
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
    default:
        guessesLeft = 1;
        break;
}

int secretNumber = new Random().Next(1, 101);
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
