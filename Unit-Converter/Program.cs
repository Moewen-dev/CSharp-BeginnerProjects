/*
 * A simple Unit Converter, that can convert Imperial to Metric and back.
 * Made by Moewen-dev
 */


// Start Menu:
static void startMenu() 
{
    Console.WriteLine("Welcome to the Simple Unit Converter.");
    Console.WriteLine("Please choose from the following options.");
    Console.WriteLine("Do not write the Unit in the input!");
    Console.WriteLine("---------------------------------------------");
    Console.WriteLine("Option 01: Meter to Foot");
    Console.WriteLine("Option 02: Meter to Inch");
    Console.WriteLine("Option 03: Meter to Yard");
    Console.WriteLine("Option 04: Foot to Meter");
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

static int getOption()
{
    try 
    { 
        int option =  Int32.Parse(Console.ReadLine());
        return option;
    }
    catch (Exception e)
    {
        Console.WriteLine("Error: " + e.ToString());
        return -1;
    }
}

static double meterToFoot(double input)
{
    return input / 0.3048D;
}

while (true)
{
    //Main Loop
    Console.Clear();
    startMenu();
    int option = getOption();
    if (option == 99)
    {
        Console.Clear();
        Console.WriteLine("Press Enter to Exit");
        Console.ReadKey();
        Environment.Exit(0);
    }
    else if (option == 01)
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Meter to Foot");
            Console.Write("Input: ");
            double input = Double.Parse(Console.ReadLine());
            Console.Write("");
            Console.WriteLine("Output: " + meterToFoot(input) + "Feet");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
        }
        catch (Exception e) 
        {
            Console.WriteLine("Error: " + e.ToString());
            Console.ReadKey();
        }
    }
}