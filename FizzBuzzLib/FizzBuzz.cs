using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {
        public System.String FizzBuzzifyAnInt(System.Int32 pintInput)
        {
            System.String strReturn = pintInput.ToString();
            //Where input is a multiple of 3, method should return "Fizz"
            if (pintInput % 3 == 0)
            //using a modulo operation to determine if it divisible by 3
            {
                strReturn = "Fizz";
            }
            //Where input is a multiple of 5, method should return "Buzz"
            if (pintInput % 5 == 0)
            {
                strReturn = "Buzz";
            }
            //Where input is a multiple of 3 and 5 (e.g. 15), method should return "FizzBuzz"
            if (pintInput % 3 == 0 && pintInput % 5 == 0)
            {
                strReturn = "FizzBuzz";
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
