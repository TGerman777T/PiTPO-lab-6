using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTestApp
{
    internal class Calculator
    {
        public static int CalculateSum(string numbers, char delimiter = ',')
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var numArray = numbers.Split(delimiter).Select(n =>
            {
                if (!int.TryParse(n, out int num))
                {
                    throw new Exception("Input string contains non-numeric characters.");
                }
                return num;
            })
                                  .Where(n => n <= 10)
                                  .Take(5)
                                  .ToArray();

            if (numArray.Any(n => n < 0))
            {
                return 0;
            }

            return numArray.Sum();
        }
    }
}
