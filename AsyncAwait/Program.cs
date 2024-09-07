using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var task = client.GetStringAsync($"https://google.com");
            int a = 0;
            for(int i = 0;i<1_000_000;i++)
            {
                a = i + 1;
            }
            var page = await task;
            Console.WriteLine("Hello World");
        }
    }
}
