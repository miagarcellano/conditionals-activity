using System;

class Practice1_5
{
    public static void Run()
    {
        char choice;

        do
        {
            Console.WriteLine("\n--- Options ---");
            Console.WriteLine("A - Compute Area");
            Console.WriteLine("P - Compute Perimeter");
            Console.WriteLine("X - Exit");
            Console.Write("Enter option [A, P, X]: ");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) continue;

            choice = char.ToUpper(input[0]);

            if (choice == 'X')
            {
                Console.WriteLine("Exiting application...");
                break;
            }

            if (choice == 'A' || choice == 'P')
            {
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());

                if (choice == 'A')
                {
                    double area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"Area: {area}");
                }
                else if (choice == 'P')
                {
                    double perimeter = 2  Math.PI  radius;
                    Console.WriteLine($"Perimeter: {perimeter}");
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }

        } while (true);
    }
}
