using System;

class Program
{   
    static void Main(string[] args)
{  
    List<int> numbers = new List<int>();
    int n = 1;
    do {
        Console.WriteLine("Enter Number: ");
        string numadd = Console.ReadLine();
        n = int.Parse(numadd);
        numbers.Add(n);
    } while (n != 0);

    int sum = 0;
    foreach (int number in numbers) {
        sum += number;
    }
    int largest = numbers.Max();
    double average = (double)sum / numbers.Count;
    Console.WriteLine($"The sum is: {sum}");
    Console.WriteLine($"Average of entered numbers: {average}");
    Console.WriteLine($"The largest number is: {largest}");
}
}