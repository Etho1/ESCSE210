using System;

class Program
{
    static void Main(string[] args)
    {   
        welcome_message();
        string name = username();
        int n = number();
        int square = sq(n);
        displayresult(name, square);


    }
        static void welcome_message()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string username()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int number()
        {
            Console.WriteLine("Please enter your favorite number:");
            string num = Console.ReadLine();
            int n;
            n = int.Parse(num);
            return n;
        }
        static int sq(int n)
        {
            int square = n*n;
            return square;
        }
        static void displayresult(string name,int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    
}