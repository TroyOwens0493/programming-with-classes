using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello Sandbox World!");

        List<double> x = new();
        // Gather data to fill a list
        double input = -1;
        while(input != 0) {
            Console.Write("Enter Something ");
            string inpurt_str = Console.ReadLine();
            input = double.Parse(inpurt_str);
            x.Add(input);
        }

        foreach (double number in x) {
            Console.WriteLine(number);
        }
    }
}
