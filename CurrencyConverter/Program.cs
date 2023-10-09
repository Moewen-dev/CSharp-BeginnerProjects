/*
 * Simple CLI Currency Converter that Supports 160 Currencies
 * Made by Meowen-dev
 */

//Main Loop
while (true)
{
    Console.Clear();
    Logic.SetMainMenu();
    string input = Logic.getInputCurrency();
    if (input == "exit" ) { Logic.stop(); }

}