using System;  // Allows us to use basic C# features like Console

namespace Csharp_Assignment2_Group8  // Namespace for the project (rename X to your group #)
{
    internal class Program
    {
        // ============================
        // METHOD 1: Print full name
        // ============================
        // This method accepts two string parameters and prints the full name to the console.
        static void PrintFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;  // Concatenate first + space + last
            Console.WriteLine("\nYour full name is: " + fullName);  // Display full name
        }

        // ============================
        // METHOD 2: Convert Celsius → Fahrenheit
        // ============================
        // This method accepts a double (Celsius) and returns a double (Fahrenheit)
        static double ConvertCToF(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;  // Apply conversion formula
            return fahrenheit;  // Return converted Fahrenheit value
        }

        // ============================
        // METHOD 3: Convert Fahrenheit → Celsius
        // ============================
        // This method accepts a double (Fahrenheit) and returns a double (Celsius)
        static double ConvertFToC(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;  // Apply conversion formula
            return celsius;  // Return converted Celsius value
        }

        // ============================
        // METHOD 4: Custom method (BMI Calculator)
        // ============================
        // Accepts weight in kg and height in meters, returns BMI as double
        static double CalculateBMI(double weightKg, double heightMeters)
        {
            if (heightMeters <= 0)  // Prevent division by zero
            {
                Console.WriteLine("Height must be greater than zero. Returning 0.");  // Error message
                return 0;  // Return safe value
            }

            double bmi = weightKg / (heightMeters * heightMeters);  // BMI formula
            return bmi;  // Return the BMI result
        }

        // ============================
        // MAIN METHOD – This runs first
        // ============================
        static void Main(string[] args)
        {
            Console.WriteLine("===== C# Assignment 2 - Methods Demo =====\n");  // Title

            // ---------------------------------------------------------
            // PART 1: Full Name Input + Method Call
            // ---------------------------------------------------------
            Console.WriteLine(">>> Part 1: Full Name (Concatenation)");  // Section title

            Console.Write("Enter your first name: ");  // Ask user for first name
            string firstName = Console.ReadLine();      // Read first name input

            Console.Write("Enter your last name: ");    // Ask user for last name
            string lastName = Console.ReadLine();        // Read last name input

            PrintFullName(firstName, lastName);   // Call method to print full name

            // ---------------------------------------------------------
            // PART 2: Celsius → Fahrenheit
            // ---------------------------------------------------------
            Console.WriteLine("\n>>> Part 2: Convert Celsius to Fahrenheit");  // Section title

            Console.Write("Enter temperature in Celsius: ");  // Ask for Celsius
            string celsiusInput = Console.ReadLine();         // Read input as string

            double celsiusValue;  // Variable to store converted numeric value

            if (double.TryParse(celsiusInput, out celsiusValue))  // Validate if input is a number
            {
                double resultF = ConvertCToF(celsiusValue);  // Call method
                Console.WriteLine(celsiusValue + " °C = " + resultF + " °F");  // Print result
            }
            else
            {
                Console.WriteLine("Invalid input for Celsius temperature.");  // Error message
            }

            // ---------------------------------------------------------
            // PART 3: Fahrenheit → Celsius
            // ---------------------------------------------------------
            Console.WriteLine("\n>>> Part 3: Convert Fahrenheit to Celsius");  // Section title

            Console.Write("Enter temperature in Fahrenheit: ");  // Ask for Fahrenheit
            string fahrenheitInput = Console.ReadLine();         // Read input

            double fahrenheitValue;  // Variable to store numeric value

            if (double.TryParse(fahrenheitInput, out fahrenheitValue))  // Validate number
            {
                double resultC = ConvertFToC(fahrenheitValue);  // Call method
                Console.WriteLine(fahrenheitValue + " °F = " + resultC + " °C");  // Show result
            }
            else
            {
                Console.WriteLine("Invalid input for Fahrenheit temperature.");  // Error message
            }

            // ---------------------------------------------------------
            // PART 4: Custom Method – BMI
            // ---------------------------------------------------------
            Console.WriteLine("\n>>> Part 4: Custom Method - BMI Calculator");  // Section title

            Console.Write("Enter your weight in kilograms (kg): ");  // Ask weight
            string weightInput = Console.ReadLine();                 // Read weight

            Console.Write("Enter your height in meters (m): ");      // Ask height
            string heightInput = Console.ReadLine();                 // Read height

            double weightKg, heightMeters;  // Variables to store numeric inputs

            // Validate both inputs
            if (double.TryParse(weightInput, out weightKg) &&
                double.TryParse(heightInput, out heightMeters))
            {
                double bmi = CalculateBMI(weightKg, heightMeters);  // Call BMI method
                Console.WriteLine("Your BMI is: " + bmi);           // Print result
            }
            else
            {
                Console.WriteLine("Invalid input for weight or height.");  // Error
            }

            Console.WriteLine("\n===== End of Program. Press any key to exit. =====");  // End message
            Console.ReadKey();  // Wait for key press so console doesn’t close
        }
    }
}
