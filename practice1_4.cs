using System;

class Practice1_4
{
    public static void Run()
    {
        Console.Write("Enter student score: ");
        double score = double.Parse(Console.ReadLine());

        string result = (score >= 50) ? "Passed" : "Failed";
        Console.WriteLine(result);
    }
}
