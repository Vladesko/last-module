using Newtonsoft.Json;
using System;
using System.Linq;

namespace LastModule
{
    public class MyConvert
    {
        public string TypeOperation { get; set; }
        public MyConvert(string typeOfOperation)
        {
            TypeOperation = typeOfOperation;
        }
        public object Convert(string value)
        {
            switch (TypeOperation)
            {
                case "1":
                    return ConvertToDouble(value);
                case "2":
                    return ConvertToInt(value);
                default: return 0;
            }
        }
        private double ConvertToDouble(string value)
        {
            try
            {
                string json = JsonConvert.SerializeObject(value);
                double result = JsonConvert.DeserializeObject<double>(json);
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine("YOUR NUMBER HAVE A WRONG FORMAT!!!"); //return 0 its bad idea because this data might crash all programm
                return 0;
            }
        }
        private int ConvertToInt(string value)
        {
            try
            {
                string json = JsonConvert.SerializeObject(value);
                int result = JsonConvert.DeserializeObject<int>(json);
                return result;
            }
            catch (Exception)
            {
                Console.WriteLine("YOUR NUMBER HAVE A WRONG FORMAT!!!"); //return 0 its bad because this data might crash all programm
                return 0;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number");
            string number = Console.ReadLine();
            Console.WriteLine("Write your type:" +
                "\n1.Double" +
                "\n2.Int");
            string typeOfoperation = Console.ReadLine();
            //Version 1.0
            MyConvert myConvert = new MyConvert(typeOfoperation);
            var result = myConvert.Convert(number);

            Console.WriteLine($"Your value is {result}");
        }
    }
}
