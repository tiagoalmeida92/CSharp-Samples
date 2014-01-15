using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Async
{
    class Program
    {
        /// <summary>
        /// Http Request async via HttpClient
        /// </summary>

        static async Task<String> GetPageAsync(string url)
        {
            var httpClient = new HttpClient();
            Task<String> t = httpClient.GetStringAsync(url);


            String result = await t;



            return result;
        }


        static void Main(string[] args)
        {
            string url = "http://www.google.pt";
            var res = GetPageAsync(url);
            Console.WriteLine(res.Result);

        }
    }
}
