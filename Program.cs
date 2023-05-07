using Newtonsoft.Json;
using System;
using System.Linq;

namespace LastModule
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            string number = Console.ReadLine();
            //Version 1.0
            try
            {
                string json = JsonConvert.SerializeObject(number);
                int value = JsonConvert.DeserializeObject<int>(json);
                Console.WriteLine($"Your value is a {value}");
            }
            catch (Exception)
            {
                Console.WriteLine("Your number have a wrong format");
            }
        }
    }
}
