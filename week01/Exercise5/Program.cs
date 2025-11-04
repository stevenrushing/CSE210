using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // static void DisplayMessage()
        // {
        //     Console.WriteLine("Hello world!");
        // }

        // static void DisplayPersonalMessage(string userName)
        // {
        //     Console.WriteLine($"Hello {userName}");
        // }

        // static int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNum = int.Parse(Console.ReadLine());
            return userNum;
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Howdy {name}, the square of your number is {number}");
        }
        DisplayMessage();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(name, squaredNumber);



    }
}