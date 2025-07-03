using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp
{
    public class FizzBuzzApp
    {
        public string CalculateFizzBuzz(int number)
        {
            if(number % 5 == 0 & number % 3 == 0)
            {
                return "FizzBuzz";
            }

            if(number % 5 == 0)
            {
                return "Buzz";
            }

            if(number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }

        public string MassCalculateFizzBuzz(int[] input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    output += CalculateFizzBuzz(input[i]);
                }
                else
                {
                    output += "," + CalculateFizzBuzz(input[i]);
                }                
            }
            return output;
        }
    }
}
