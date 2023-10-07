/*
 * A simple Unit Converter, that can convert Imperial to Metric and back.
 * Made by Moewen-dev
 */
using Unit_Converter;

while (true)
{
    //Main Loop
    Console.Clear();
    Logic.startMenu();
    int option = Logic.getOption();
    
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
            Console.WriteLine("Output: " + Logic.meterToFeet(input) + " feet");
            Console.WriteLine("Press Enter to Continue");
            Console.ReadKey();
        }
        catch (Exception e) 
        {
            Console.WriteLine("Error: Invalid Input!");
            Console.WriteLine("Error: Only Numbers are Valid!");
            Console.WriteLine("Press Enter to Return to the Menu");
            Console.ReadKey();
        }
    }
    else if (option == 02)
    {
        Console.Clear();
    }
    
}