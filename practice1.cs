using System;

class Practice1
{
    public static void Run()
    {
        // 1. Integer Practice: Add two whole numbers
        Console.WriteLine("--- Integer Practice ---");
        Console.Write("Enter first whole number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second whole number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {num1 + num2}\n");

        // 2. Float Practice: Average of three test scores
        Console.WriteLine("--- Float Practice ---");
        Console.Write("Enter first test score: ");
        float score1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second test score: ");
        float score2 = float.Parse(Console.ReadLine());
        Console.Write("Enter third test score: ");
        float score3 = float.Parse(Console.ReadLine());
        float average = (score1 + score2 + score3) / 3f;
        Console.WriteLine($"Average: {average:F2}\n");

        // 3. Double Practice: Area of a circle
        Console.WriteLine("--- Double Practice ---");
        Console.Write("Enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area: {area}\n");

        // 4. String Practice: Full Name Concatenation
        Console.WriteLine("--- String Practice ---");
        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Full Name: {firstName} {lastName}");
    }
}
