using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("ismail", "candan");

            Console.WriteLine("Hello World!");
        }
    }
}
