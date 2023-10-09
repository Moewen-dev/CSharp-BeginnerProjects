/*
 * Simple CLI Currency Converter that Supports 160 Currencies
 * Made by Meowen-dev
 */

internal class Logic
{
    //Print Main Menu in CLI
    public static void SetMainMenu()
    {
        Console.WriteLine("----------------Main-Menu----------------");
        Console.WriteLine("Welcome to a Currency Converter");
        Console.WriteLine("Just enter the Currency you want to Convert from \nand enter the Currency you want to Convert to in the Next Prompt!");
        Console.WriteLine("In the Last Prompt you just put in the amount you want to Convert");
        Console.WriteLine("Here is an Example: EUR to USD and 100");
        Console.WriteLine("-----------------------------------------");
    }

    //Method to exit the Program
    public static void stop () { Environment.Exit(0); }
}