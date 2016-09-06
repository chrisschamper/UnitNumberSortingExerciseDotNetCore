using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UnitNumberSortingExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(!(args.Count() == 1))
            {
                //Incorrect number of arguments
                //Expectiing one (1)
                Console.WriteLine("Please supply only input text file.");
                Console.WriteLine("Found " + args.Count() + " arguments!");
            }
            else
            {
                var fs = File.Open(args[0], FileMode.Open);
                var sr = new StreamReader(fs);
                var data = sr.ReadToEnd();
                var result = Logic.Logic.Sort(data);
                Console.Write(result);
            }
        }
    }
}
