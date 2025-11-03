using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int secret = randomGenerator.Next(1, 11);

            int guess = 0;

            while (guess != secret)
            {
                Console.Write("What is your guess? ");
                string guessString = Console.ReadLine();
                guess = int.Parse(guessString);

                if (guess < secret)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Would you like to play again? (yes/no) ");
            response = Console.ReadLine();
        }

    }
}


// What is the magic number? 18
//   What is your guess? 5
//   Higher
//   What is your guess? 6
//   Higher
//   What is your guess? 7
//   Higher
//   What is your guess? 20
//   Lower
//   What is your guess? 19
//   Lower
//   What is your guess? 18
//   You guessed it!