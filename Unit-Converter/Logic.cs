﻿namespace Unit_Converter
{
    public class Logic
    {
        //Start Menu
        public static void startMenu()
        {
            Console.WriteLine("Welcome to the Simple Unit Converter.");
            Console.WriteLine("Please choose from the following options.");
            Console.WriteLine("Do not write the Unit in the input!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Option 01: Meter to Feet");
            Console.WriteLine("Option 02: Meter to Inch");
            Console.WriteLine("Option 03: Meter to Yard");
            Console.WriteLine("Option 04: Feet to Meter");
            Console.WriteLine("Option 05: Inch to Meter");
            Console.WriteLine("Option 06: Yard to Meter");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Option 07: Fahrenheit to Celsius");
            Console.WriteLine("Option 08: Celsius to Fahrenheit");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Option 09: Gram to Ounce");
            Console.WriteLine("Option 10: Gram to Pound");
            Console.WriteLine("Option 11: Gram to Kilogram");
            Console.WriteLine("Option 12: Ounce to Gram");
            Console.WriteLine("Option 13: Pound to Gram");
            Console.WriteLine("Option 14: Kilogram to Gram");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Option 99: Exit");
        }

        //Get the Option the User wants to use
        public static int getOption()
        {
            Console.WriteLine("");
            Console.Write("Option Picked: ");
            try
            {
                int option = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                return option;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Error: Only Numbers are Valid!");
                Console.WriteLine("Press Enter to Return to the Menu");
                Console.ReadKey();
                return -1;
            }
        }

        //Convert Meter to Feet
        private static float meterToFeet(float input) { return input / 0.3048f; }

        //Convert Meter to Inch
        private static float meterToInch(float input) { return input / 0.0254f; }

        //Convert Meter to Yard
        private static float meterToYard(float input) { return input / 0.9144f; }

        //Convert Feet to Meter
        private static float feetToMeter(float input) { return input * 0.3048f; }

        //Convert Inch to Meter
        private static float inchToMeter(float input) { return input * 0.0254f; }

        //Convert Yard to Meter
        private static float yardToMeter(float input) { return input * 0.9144f; }

        //Convert Fahrenheit to Celsius
        private static float fahrenheitToCelsius(float input) 
        { 
            return (input - 32) * 5 / 9; 
        }

        //Output Method
        public static void output(int optionID)
        {
            Console.Clear();
            switch (optionID)
            {
                case 99:
                    Console.WriteLine("Press Enter to Exit");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 01:
                    try
                    {
                        Console.WriteLine("Meter to Foot");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + meterToFeet(input) + "ft");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 02:
                    try
                    {
                        Console.WriteLine("Meter to Inch");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + meterToInch(input) + "in");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 03:
                    try
                    {
                        Console.WriteLine("Meter to Yard");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + meterToYard(input) + " yd");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 04:
                    try
                    {
                        Console.WriteLine("Feet to Meter");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + feetToMeter(input) + "m");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 05:
                    try
                    {
                        Console.WriteLine("Inch to Meter");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + inchToMeter(input) + "m");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 06:
                    try
                    {
                        Console.WriteLine("Yard to Meter");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + yardToMeter(input) + "m");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
                case 07:
                    try
                    {
                        Console.WriteLine("Fahrenheit to Celsius");
                        Console.Write("Input: ");
                        float input = float.Parse(Console.ReadLine());
                        Console.Write("");
                        Console.WriteLine("Output: " + fahrenheitToCelsius(input) + "°C");
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Input!");
                        Console.WriteLine("Error: Only Numbers are Valid!");
                        Console.WriteLine("Press Enter to Return to the Menu");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
