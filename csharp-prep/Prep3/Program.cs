using System;

class Program
{
    static void Main(string[] args)
    {
        
        int g = (7);
        int count = (0);
        string replay = ("");
        int number = (0);
        do{
            do
            {
                Random randomGenerator = new Random();
                number = randomGenerator.Next(1,11);

                Console.WriteLine("What is the magic number?");
                string guess = Console.ReadLine();
                g = int.Parse(guess);

                if (g == number){
                    Console.WriteLine("You guessed it!");
                }
                else if (g>number){
                    Console.WriteLine("Lower");
                }
                else if (g<number){
                    Console.WriteLine("Higher");
                }
                count = (count + 1);
            } while (g != number);
            Console.WriteLine($"It took you {count} tries.");
            Console.WriteLine("Would you like to play again?");
            replay = Console.ReadLine();
        } while (replay == "yes");

    }
}
