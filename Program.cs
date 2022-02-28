using System;

int secretNumber = 42;

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
