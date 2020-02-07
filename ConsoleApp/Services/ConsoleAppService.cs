using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ConsoleApp.Services
{
    class ConsoleAppService
    {
        public string GetMessage()
        {
            string URL = ConfigurationManager.AppSettings["HelloWorldAPIURL"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                //HTTP GET
                var responseTask = client.GetAsync("helloworld");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    return readTask.Result.ToString();

                }
                else
                {
                    return "no value";
                }
            }

        }

    }
}
