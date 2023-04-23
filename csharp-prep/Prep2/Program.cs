using System;

class Program
{
    static void Main(string[] args)
    {
        string letter ="";
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        float g = float.Parse(grade);
        if (g >= 90)
        {
            letter = "A";
        }
        else if (g >= 80)
        {
            letter ="B";
        }
        else if (g >= 70)
        {
            letter ="C";
        }
        else if (g >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}");
        if (g >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}