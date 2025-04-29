using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Random randomGen = new Random();

        int randomNumber = randomGen.Next(1,1000);
        string guess = "";
        int guesses = 0;

        Console.WriteLine("I have picked a random number between 1 and 1000. how long till you guess?");

        while (int.Parse(guess) != randomNumber) 
        {
            
            guesses ++;
            Console.WriteLine("What is your guess?  ");
            guess = Console.ReadLine();
            if (int.Parse(guess) > randomNumber)
            {
                Console.WriteLine("Nope, that's not it. You guessed too low.");
            }
            else if (int.Parse(guess) < randomNumber)
            {
                Console.WriteLine("Nope, you guessed too low. ");
            }

            else if (int.Parse(guess) == randomNumber)
            {
                Console.WriteLine($"You got it! very nice. it took you {guesses} tries.");
            }

            else {
                Console.WriteLine("an error has occured.");
            }
        }
        

    }

}