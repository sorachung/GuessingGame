using System;

Console.WriteLine(@"Please choose a difficulty level:
1) Easy
2) Medium
3) Hard
4) Cheater");

int guessesLeft = 0;
bool cheater = false;
bool inputCorrectly = false;
while (!inputCorrectly)
{
    string difficultyChoice = Console.ReadLine();
    switch (difficultyChoice)
    {
        case "1":
            guessesLeft = 8;
            inputCorrectly = true;
            break;
        case "2":
            guessesLeft = 6;
            inputCorrectly = true;
            break;
        case "3":
            guessesLeft = 4;
            inputCorrectly = true;
            break;
        case "4":
            guessesLeft = 0;
            inputCorrectly = true;
            cheater = true;
            break;
        default:
            Console.WriteLine("Please input 1, 2, 3, or 4");
            break;
    }
}

int secretNumber = new Random().Next(1, 101);

while (guessesLeft > 0 || cheater)
{
    if (!cheater)
    {
        if (guessesLeft == 1)
        {
            Console.WriteLine($"You have 1 guess left.");
        }
        else
        {
            Console.WriteLine($"You have {guessesLeft} guesses left.");
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
    else if (guess > secretNumber)
    {
        Console.WriteLine("You guessed too HIGH!");
    }
    else
    {
        Console.WriteLine("You guessed too LOW!");
    }
    guessesLeft--;

}

Console.WriteLine("End Game");