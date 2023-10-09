/*
 * Simple CLI Currency Converter that Supports 160 Currencies
 * Made by Meowen-dev
 */

using System.Runtime.CompilerServices;

internal class Logic
{
    //Print Main Menu in CLI
    public static void SetMainMenu()
    {
        Console.WriteLine("--------------------------------Main-Menu--------------------------------");
        Console.WriteLine("Welcome to a Currency Converter");
        Console.WriteLine("Just enter the Currency you want to Convert from \nand enter the Currency you want to Convert to in the Next Prompt!");
        Console.WriteLine("In the Last Prompt you just put in the amount you want to Convert");
        Console.WriteLine("Here is an Example: EUR to USD and 100");
        Console.WriteLine("If you want to exit type \"exit\" ");
        Console.WriteLine("-------------------------------------------------------------------------");
    }

    //Method to exit the Program
    public static void stop()
    { 
        Console.WriteLine("Press enter to exit");
        Console.ReadKey();
        Environment.Exit(0);
    }

    //Get The Input Currency
    public static string getInputCurrency()
    {
        Console.WriteLine("Enter your starting Currency");
        Console.Write("Input: ");
        string input = Console.ReadLine();
        if (input != null) { return input; }
        else { throw new Exception("Invalid Input"); }
    }

    //Set the Input Currency
}