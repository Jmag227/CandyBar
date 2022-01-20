using System;
using System.Net.Http;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {  
                       
            var client = new HttpClient();
            var apiKey = "";
            var URL = "https://amazon-data-product-scraper.p.rapidapi.com/products/B08N5LM1K3?api_key=548851825ac43f460f8ec20f2c8ab823";

            string response = client.GetStringAsync(URL).Result;
            Console.WriteLine(response);









        }
    }
}
