using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string sign = "";

        if (grade < 95 && grade > 60) {
            if ((grade % 10) >= 7) {
                sign = "+";
            }

            if ((grade % 10) < 3)
            {
                sign = "-";
            }
        }



        if (grade >= 90) {
            Console.WriteLine($"Your grade is an A{sign}");
        }
        else if (grade > 80) {
            Console.WriteLine($"Your grade is a B{sign}");
        }
        else if (grade > 70) {
            Console.WriteLine($"Your grade is a C{sign}");
        }
        else if (grade > 60) {
            Console.WriteLine($"Your grade is a D{sign}");
        }
        else
        {
            Console.WriteLine($"Your grade is an F");
        }

    }
}