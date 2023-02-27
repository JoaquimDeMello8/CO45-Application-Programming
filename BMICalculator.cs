using System;
using Internal;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the program heading and introduction
            Console.WriteLine("----------------------------------");
            Console.WriteLine("BMI Calculator by Joaquim De Mello");
            Console.WriteLine("----------------------------------\n");
            Console.WriteLine("This application will calculate your BMI and WHO weight status based on your weight and height.\n");

            // Prompt the user to select unit of measurement
            Console.WriteLine("Select unit of measurement:\n");
            Console.WriteLine("1. Metric (kg, m)");
            Console.WriteLine("2. Imperial (lb, in)\n");
            Console.Write("Enter your choice (1 or 2): ");

            // Read the user's choice of unit of measurement
            int unitChoice;
            bool validUnitChoice = int.TryParse(Console.ReadLine(), out unitChoice);

            // Declare variables for weight and height
            double weight;
            double height;

            // Calculate BMI and WHO weight status based on the selected unit of measurement
            if (validUnitChoice && (unitChoice == 1 || unitChoice == 2))
            {
                // Prompt the user to enter their weight and height
                Console.Write("\nEnter your weight: ");
                string weightLabel = unitChoice == 1 ? "kg" : "lb";
                bool validWeight = double.TryParse(Console.ReadLine(), out weight);

                Console.Write("Enter your height: ");
                string heightLabel = unitChoice == 1 ? "m" : "in";
                bool validHeight = double.TryParse(Console.ReadLine(), out height);

                if (validWeight && validHeight)
                {
                    // Calculate BMI
                    if (unitChoice == 1)
                    {
                        weight = weight / 1.0;
                        height = height / 1.0;
                    }
                    else
                    {
                        weight = weight * 0.45359237;
                        height = height * 0.0254;
                    }
                    double bmi = weight / (height * height);

                    // Determine WHO weight status based on BMI
                    string whoWeightStatus;
                    if (bmi < 18.5)
                    {
                        whoWeightStatus = "Underweight";
                    }
                    else if (bmi < 25)
                    {
                        whoWeightStatus = "Normal";
                    }
                    else if (bmi < 30)
                    {
                        whoWeightStatus = "Overweight";
                    }
                    else if (bmi < 35)
                    {
                        whoWeightStatus = "Obese Class I";
                    }
                    else if (bmi < 40)
                    {
                        whoWeightStatus = "Obese Class II";
                    }
                    else
                    {
                        whoWeightStatus = "Obese Class III";
                    }

                    // Display the BMI and WHO weight status
                    Console.WriteLine($"\nYour BMI is {bmi:F2} kg/m².");
                    Console.WriteLine($"Your WHO weight status is {whoWeightStatus}.");
                }
                else
                {
                    // Display an error message for invalid weight or height
                    Console.WriteLine("\nInvalid weight or height. Please enter a valid number.");
                }
            }
            else
            {
                // Display an error message for invalid choice of unit of measurement
                Console.WriteLine("\nInvalid choice of unit of measurement. Please enter 1 or 2.");
            }

            // Display a message for BAME groups about their extra risks
            Console.WriteLine("\nNote: People from black, Asian and other minority ethnic groups may be at extra risk of health problems at a lower BMI than the standard threshold.");
        }
    }
}