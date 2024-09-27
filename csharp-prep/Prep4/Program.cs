using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        List<int> userListOfNumbers = new();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do {
            Console.Write("Enter number ");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber ==  0) {
                running = false;
            } else {
                userListOfNumbers.Add(userNumber);
            }
        } while (running);
        userListOfNumbers.Sort();
        int sum = 0;
        double average = new();
        int largest = 0;
        int smallest = int.MaxValue;
        foreach (int num in userListOfNumbers) {
            sum += num;
            if (num > largest) {
                largest = num;
            }
            if (num < smallest && num > 0) {
                smallest = num;
            }
        }
        average = (double) sum / userListOfNumbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in userListOfNumbers) {
            Console.WriteLine($"{num}");
        }
    }
}
