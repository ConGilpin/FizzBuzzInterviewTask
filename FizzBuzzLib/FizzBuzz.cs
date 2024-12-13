using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {
        public Dictionary<int, string> ReplacementPairs { get; set; }

        public FizzBuzz()
        {
            //Setting default dictionary values
            ReplacementPairs = new Dictionary<int, string>()
        {
            { 3, "Fizz"},
            { 5, "Buzz"}
            };
        }
        public System.String FizzBuzzifyAnInt(System.Int32 pintInput)
        {
            System.String strReturn = "";
            //Looping through each dictionary item to verify any multiples in a given range
            foreach (var pair in ReplacementPairs)
            {
                //Check to see if the input is a multiple of the key in the dictionary
                if (pintInput % pair.Key == 0)
                {
                    strReturn += pair.Value;
                }
            }
            if (strReturn == "")
            {
                strReturn = pintInput.ToString();
            }
            return strReturn;
        }
        public IEnumerable<System.String> FizzBuzzValuesForRange(System.Int32 pintStart, System.Int32 pintEnd)
        {
            List<System.String> listReturn = new List<System.String>();
            //iterate through the given ranges
            while (pintStart <= pintEnd)
            {
                //Call the fizzbuzz function
                listReturn.Add(FizzBuzzifyAnInt(pintStart));
                pintStart++;
            }
            return listReturn;
        }
    }
}
