using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            DictionaryInitialize(dic);
            
            var rnd = new Random();
            string symbol = "";

            int a = 0, b = 0, c = 0, d = 0;
            for (int i = 0; i <= 10000; i++)
            {
                symbol = WeightedRandom.WeightedRandom.GetWeightedRandom(dic, rnd).Key;
                if (symbol == "A")
                { a++; }
                else if (symbol == "B")
                { b++; }
                else if (symbol == "C")
                { c++; }
                else if (symbol == "D")
                { d++; }                
            }

            Console.WriteLine("A = " + a.ToString() + " B = " + b.ToString() + " C = " + c.ToString() + " D = " + d.ToString());
            Console.ReadLine();
        }
       
        private static void DictionaryInitialize(Dictionary<string, int> dic)
        {
            dic.Add("A", 1);
            dic.Add("B", 2);
            dic.Add("C", 8);
            dic.Add("D", 4);
        }
    }
}
