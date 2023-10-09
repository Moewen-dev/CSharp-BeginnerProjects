/*
 * Simple CLI Currency Converter that Supports 160 Currencies
 * Made by Meowen-dev
 */

using System.Runtime.CompilerServices;
using System.Transactions;

internal class Logic
{
    //Print Main Menu in CLI
    public static void SetMainMenu()
    {
        string mainMenu = @"
--------------------------------Main-Menu--------------------------------
Welcome to a Currency Converter
Just enter the Currency you want to Convert from 
and enter the Currency you want to Convert to in the Next Prompt!
In the Last Prompt you just put in the amount you want to Convert
here is an Example: EUR to USD and 100
If you want to exit type ""exit""
-------------------------------------------------------------------------";
        Console.WriteLine(mainMenu);
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

    //Get the Output Currency
    public static string getOutputCurrency()
    {
        Console.WriteLine("Enter your desired Output Currency");
        Console.Write("Input: ");
        string output = Console.ReadLine();
        if (output != null) { return output; } 
        else { throw new Exception("Invalid Input"); }
    }

    //Get the amount of Currency to Convert
    public static float getMoney()
    {
        Console.WriteLine("Enter the amount you want to Convert");
        Console.Write("Amount: ");
        try
        {
            float amount = float.Parse(Console.ReadLine());
            return amount;
        }
        catch (Exception)
        {
            throw new Exception("Invalid Input");
        } 
    }
}