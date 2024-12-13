namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            //Console.WriteLine("Input a starting Integer Value: ");
            //System.Int32 intStart = System.Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input an ending Integer Value: ");
            //System.Int32 intEnd = System.Convert.ToInt32(Console.ReadLine());
            //IEnumerable<System.String> value = fizzBuzzer.FizzBuzzValuesForRange(intStart, intEnd);
            IEnumerable<System.String> value = fizzBuzzer.FizzBuzzValuesForRange(1, 100);
            //Loop through each item given back
            foreach (string item in value)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
