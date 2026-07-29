using System;

class Practice2
{
    public static void Run()
    {
        Console.Write("Enter Principal amount: ");
        double principal = double.Parse(Console.ReadLine());

        Console.Write("Enter Rate of interest (%): ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = double.Parse(Console.ReadLine());

        double interest = (principal  rate  time) / 100;
        Console.WriteLine($"Simple Interest: {interest}");
    }
}
