using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //************************************************PROBLEM 1****************************************//
            //Using LINQ, write a function that returns all words that contain the substring “th” from a list.

            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var substring = words.Where(w => w.Contains("th"));
            foreach (var word in substring)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //*******************************************************PROBLEM 2**********************************************//
            // Using LINQ, write a function that takes in a list of strings and returns a copy of the list without duplicates.
            
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var newNameList = names.Distinct();
            foreach (string n in newNameList)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            //*******************************************************PROBLEM 3************************************************//
            // Using LINQ, write a function that calculates the class grade average after dropping the lowest grade 
            // for each student. The function should take in a list of strings of grades (e.g., one string might be 
            //"90,100,82,89,55"), drops the lowest grade from each string, averages the rest of the grades from that
            //string, then averages the averages.
            List<string> classGrades = new List<string>()
            {
                "80, 100, 92, 89, 65", // Drop 65
                "93, 81, 78, 84, 69",  // Drop 69
                "73, 88, 83, 99, 64",  // Drop 64
                "98, 100, 66, 74, 55"  // Drop 55
             };
        }
        //foreach (var item in collection)
    }
}
