namespace Unit_Converter
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
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
                return -1;
            }
        }

        //Convert Meter to Feet
        private static float meterToFeet(float input) { return input / 0.3048f; }

        //Convert Meter to Inch
        private static float meterToInch(float input) { return input / 0.0254f; }

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
            }
        }
    }
}
