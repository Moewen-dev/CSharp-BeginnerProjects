/*
 * A simple Unit Converter, that can convert Imperial to Metric and back.
 * Made by Moewen-dev
 */
using Unit_Converter;

//Main Loop
while (true)
{
    Console.Clear();
    Logic.startMenu();
    int option = Logic.getOption();
    Logic.output(option);
}
