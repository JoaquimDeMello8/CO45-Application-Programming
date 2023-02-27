
using System;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance Converter");
            Console.WriteLine("------------------");

            Console.WriteLine("Please enter the distance: ");
            string distanceString = Console.ReadLine();
            double distance = 0;

            if (!double.TryParse(distanceString, out distance))
            {
                Console.WriteLine("Error: Invalid distance entered.");
                return;
            }

            Console.WriteLine("Enter the unit of the distance: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            Console.WriteLine("4. Inches");
            Console.WriteLine("5. Kilometres");
            Console.WriteLine("6. Centimetres");
            string unitString = Console.ReadLine();
            int unit = 0;

            if (!int.TryParse(unitString, out unit) || (unit < 1 || unit > 6))
            {
                Console.WriteLine("Error: Invalid unit choice entered.");
                return;
            }

            Console.WriteLine("Please enter the number corresponding to the unit of measurement you'd like to convert to: ");
            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            Console.WriteLine("4. Inches");
            Console.WriteLine("5. Kilometres");
            Console.WriteLine("6. Centimetres");
            string convertToString = Console.ReadLine();
            int convertTo = 0;

            if (!int.TryParse(convertToString, out convertTo) || (convertTo < 1 || convertTo > 6))
            {
                Console.WriteLine("Error: Please select a number from 1 to 6.");
                return;
            }

            if (unit == 1 && convertTo == 2)
            {
                Console.WriteLine(distance + " miles = " + (distance * 5280) + " feet");
            }
            else if (unit == 1 && convertTo == 3)
            {
                Console.WriteLine(distance + " miles = " + (distance * 1609.34) + " metres");
            }
            else if (unit == 1 && convertTo == 4)
            {
                Console.WriteLine(distance + " miles = " + (distance * 63360) + " inches");
            }
            else if (unit == 1 && convertTo == 5)
            {
                Console.WriteLine(distance + " miles = " + (distance * 1.609) + " kilometres");
            }
            else if (unit == 1 && convertTo == 6)
            {
                Console.WriteLine(distance + " miles = " + (distance * 160900) + " centimetres");
            }
            else if (unit == 2 && convertTo == 1)
            {
                Console.WriteLine(distance + " feet = " + (distance / 5280) + " miles");
            }
            else if (unit == 2 && convertTo == 3)
            {
                Console.WriteLine(distance + " feet = " + (distance / 3.281) + " metres");
            }
            else if (unit == 2 && convertTo == 4)
            {
                Console.WriteLine(distance + " feet = " + (distance * 12) + " inches");
            }
            else if (unit == 2 && convertTo == 5)
            {
                Console.WriteLine(distance + " feet = " + (distance / 3281) + " kilometres");
            }
            else if (unit == 2 && convertTo == 6)
            {
                Console.WriteLine(distance + " feet = " + (distance * 30.48) + " centimetres");
            }
            else if (unit == 3 && convertTo == 1)
            {
                Console.WriteLine(distance + " metres = " + (distance / 1609.34) + " miles");
            }
            else if (unit == 3 && convertTo == 2)
            {
                Console.WriteLine(distance + " metres = " + (distance * 3.281) + " feet");
            }
            else if (unit == 3 && convertTo == 4)
            {
                Console.WriteLine(distance + " metres = " + (distance * 39.37) + " inches");
            }
            else if (unit == 3 && convertTo == 5)
            {
                Console.WriteLine(distance + " metres = " + (distance * 1000) + " kilometres");
            }
            else if (unit == 3 && convertTo == 6)
            {
                Console.WriteLine(distance + " metres = " + (distance * 100) + " centimetres");
            }
            else if (unit == 4 && convertTo == 1)
            {
                Console.WriteLine(distance + " inches = " + (distance / 63360) + " miles");
            }
            else if (unit == 4 && convertTo == 2)
            {
                Console.WriteLine(distance + " inches = " + (distance / 12) + " feet");
            }
            else if (unit == 4 && convertTo == 3)
            {
                Console.WriteLine(distance + " inches = " + (distance / 39.97) + " metres");
            }
            else if (unit == 4 && convertTo == 5)
            {
                Console.WriteLine(distance + " inches = " + (distance / 39370) + " kilometres");
            }
            else if (unit == 4 && convertTo == 6)
            {
                Console.WriteLine(distance + " inches = " + (distance * 2.54) + " centimetres");
            }
            else if (unit == 5 && convertTo == 1)
            {
                Console.WriteLine(distance + " kilometres = " + (distance / 1.609) + " miles");
            }
            else if (unit == 5 && convertTo == 2)
            {
                Console.WriteLine(distance + " kilometres = " + (distance * 3281) + " feet");
            }
            else if (unit == 5 && convertTo == 3)
            {
                Console.WriteLine(distance + " kilometres = " + (distance * 1000) + " metres");
            }
            else if (unit == 5 && convertTo == 4)
            {
                Console.WriteLine(distance + " kilometres = " + (distance * 39370) + " inches");
            }
            else if (unit == 6 && convertTo == 1)
            {
                Console.WriteLine(distance + " centimetres = " + (distance / 160900) + " miles");
            }
            else if (unit == 6 && convertTo == 2)
            {
                Console.WriteLine(distance + " centimetres = " + (distance / 30.48) + " feet");
            }
            else if (unit == 6 && convertTo == 3)
            {
                Console.WriteLine(distance + " centimetres = " + (distance * 100) + " metres");
            }
            else if (unit == 6 && convertTo == 4)
            {
                Console.WriteLine(distance + " centimetres = " + (distance / 2.54) + " inches");
            }
            else if (unit == 6 && convertTo == 5)
            {
                Console.WriteLine(distance + " centimetres = " + (distance / 100000) + " kilometres");
            }
            else
            {
                Console.WriteLine("Error: Invalid conversion choice.");
            }
        }
    }
}