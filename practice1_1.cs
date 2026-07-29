using System;

class Practice1_1
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"The number {number} is even.");
        }
    }
}
