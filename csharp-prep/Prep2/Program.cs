using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the grade percentage
        double grade_in_percent;
        Console.Write("Please enter your grade as a percentage ");
        grade_in_percent = double.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter_grade;
        if (grade_in_percent >= 90.0) {
            letter_grade = "A";
        } else if (grade_in_percent >= 80.0) {
            letter_grade = "B";
        } else if (grade_in_percent >= 70.0) {
            letter_grade = "C";
        } else if (grade_in_percent >= 60.0) {
            letter_grade = "D";
        } else {
            letter_grade = "F";
        }

        // Get the ones place in the grade
        double grade_ones_digit = grade_in_percent % 10.0;

        // Determine the +/- sign
        string sign;
        if (grade_ones_digit >= 7.0 && grade_in_percent <= 90.0 && grade_in_percent >= 60.0) {
            sign = "+";
        } else if (grade_ones_digit < 3.0 && grade_in_percent <= 90.0 && grade_in_percent >= 60.0) {
            sign = "-";
        } else {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letter_grade}{sign}");
        if (grade_in_percent < 70.0) {
            Console.WriteLine("You failed the class, better luck next time!");
        } else {
            Console.WriteLine("Nice work! You passed!");
        }
    }
}
