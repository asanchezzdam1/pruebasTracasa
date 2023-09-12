using RestSharp;
using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.apilayer.com/exchangerates_data/symbols");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "DaMWY6chNhqvbq3w2t8osYPi9Jvx8tg4");

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}