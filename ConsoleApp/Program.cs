using ConsoleApp.Services;
using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleAppService consoleAppService = new ConsoleAppService();
            string result = consoleAppService.GetMessage();
            Console.WriteLine(result);
        }
    }
}
