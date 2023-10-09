/*
 * Simple CLI Currency Converter that Supports 160 Currencies
 * Made by Meowen-dev
 * Using this API: https://rapidapi.com/principalapis/api/currency-conversion-and-exchange-rates
 */

using System.Net.Http.Headers;

//Main Loop
while (true)
{
    Console.Clear();
    Logic.SetMainMenu();
    string input = Logic.getInputCurrency();
    if (input == "exit" ) { Logic.stop(); }
    string output = Logic.getOutputCurrency();
    if ( output == "exit" ) {  Logic.stop(); }
    float amount = Logic.getMoney();
    var client = new HttpClient();
    var request = new HttpRequestMessage
    {
        Method = HttpMethod.Get,
        RequestUri = new Uri($"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from={input}&to={output}&amount={amount}"),
        Headers =
    {
        { "X-RapidAPI-Key", "YOUR_API_KEY_HERE" },
        { "X-RapidAPI-Host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
    };
    using (var response = await client.SendAsync(request))
    {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        int resultPos = body.IndexOf("result");
        string result = body.Substring(resultPos);
        string onlyResult = result.TrimEnd('}').Substring(result.IndexOf(':') + 1);
        Console.WriteLine("Result: " + onlyResult + " " + output);
    }
    Console.ReadKey();
}