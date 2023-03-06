using System;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine($"Yeezy: {kanyeQuote}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine($"Ronnie: {ronQuote}");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~");
        }
	}
}

