using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace ConsoleApp10
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int resultFromTread = 0;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(5000);
                resultFromTread = 100;
            });
            thread.Start();
            Console.WriteLine(resultFromTread);

            }
        }
    public class Q {
  

    }
    public class Currencies {
        public string symbol { get; set; }
    }
    }
