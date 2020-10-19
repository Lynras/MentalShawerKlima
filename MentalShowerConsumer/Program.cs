using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MentalShowerConsumer
{
    class Program
    {
        private const string Serverurl = "http://localhost:44367/";

        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            while (true)
            {
                HttpClientHandler handler = new HttpClientHandler();

                handler.UseDefaultCredentials = true;

                using (var client = new HttpClient(handler))
                {

                    client.BaseAddress = new Uri(Serverurl);

                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("aplication/json"));

                    try
                    {


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }

                }

            }
        }
    }
}
