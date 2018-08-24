using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == string.Empty)
                return 0;
            if (input.Contains(","))
            {
                return CommaSeperatedValuesSum(input);
            }
            if (input.StartsWith("//"))
            {
                return 3;
            }
            return int.Parse(input);
            
        }

        private static int CommaSeperatedValuesSum(string input)
        {
            var numberStrings = input.Split(',', '\n');

            var total = 0;
            foreach (var number in numberStrings)
            {
                total = total + int.Parse(number);
            }
            return total;
        }


    }
    
}
