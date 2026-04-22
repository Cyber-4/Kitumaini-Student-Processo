using System;

namespace KitumainiDigitalSolutions
{
    class Program
    {
        // Global/Class-level scope variable
        static string companyName = "Kitumaini Digital Solutions";

        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the {companyName} Student Readiness System!\n");

            // Variables & Data Types
            string studentName;
            int studentAge;
            double averagePercentage;
            bool hasLaptop;
            int studyHours;

            // Console Input/Output & Type Casting
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have your own laptop for studying? (yes/no): ");
            hasLaptop = Console.ReadLine().Trim().ToLower() == "yes";

            Console.Write("How many hours a week can you dedicate to studying?: ");
            studyHours = Convert.ToInt32(Console.ReadLine());

            // Percentage Average Calculation
            Console.WriteLine("\nEnter your final percentage for three recent modules (e.g., 65, 78, 82):");

            Console.Write("Module 1 Percentage: ");
            double mod1Score = Convert.ToDouble(Console.ReadLine());

            Console.Write("Module 2 Percentage: ");
            double mod2Score = Convert.ToDouble(Console.ReadLine());

            Console.Write("Module 3 Percentage: ");
            double mod3Score = Convert.ToDouble(Console.ReadLine());

            // Expressions & Arithmetic Operators
            averagePercentage = (mod1Score + mod2Score + mod3Score) / 3.0;
            Console.WriteLine($"\n>> Calculated Average: {Math.Round(averagePercentage, 2)}% <<\n");

            // Passing all our gathered data into the method
            int readinessScore = CalculateReadiness(studentAge, averagePercentage, hasLaptop, studyHours);

            // Output Formatting & Method Overloading
            DisplayProfile(studentName);
            DisplayProfile(studentName, readinessScore);

            Console.ReadLine(); // Keeps the console window open
        }

        // Updated Method with new parameters
        static int CalculateReadiness(int age, double average, bool laptop, int hours)
        {
            int baseScore = 20;

            // Age Check (+10 max)
            if (age >= 18) { baseScore += 10; }

            // Grades Check (+30 max)
            if (average >= 75.0)
            {
                baseScore += 30; // Distinction gets max points
            }
            else if (average >= 50.0)
            {
                baseScore += 15; // Passing gets some points
            }

            // Laptop Check (+20 max)
            if (laptop) { baseScore += 20; }

            // Study Hours Check (+20 max)
            if (hours >= 20)
            {
                baseScore += 20; // 20+ hours gets max points
            }
            else if (hours >= 10)
            {
                baseScore += 10; // 10-19 hours gets some points
            }

            return baseScore;
        }

        // Method Overloading: Version 1
        static void DisplayProfile(string name)
        {
            Console.WriteLine($"\n--- Profile Created for {name} ---");
        }

        // Method Overloading: Version 2
        static void DisplayProfile(string name, int score)
        {
            Console.WriteLine($"Student: {name} | Readiness Indicator: {score}/100");
        }
    }
}