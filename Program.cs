using System;

int secretNumber = new Random().Next(1, 101);
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
