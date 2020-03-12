using System;
using System.Collections.Generic;
using System.Linq;

namespace linqPraticeProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var list = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var answer = list.Where(m => m.Contains("th"));
            //foreach (var m in answer)
            //{
            //    Console.WriteLine(m);
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            //var nextanswer = names.Distinct();
            //foreach (string n in nextanswer)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadLine();

            List<string>classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            string joined = string.Join(",", classGrades);
            classGrades.Sort();
            Console.WriteLine(classGrades.Min());




            Console.ReadLine();

        }
        
    }
}
