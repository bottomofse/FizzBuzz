using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzGousei
    {
        public string convert(int n)
        {
            var converted = "";
            if (n % 3 == 0)
            {
                converted += "Fizz";
            }

            if (n % 5 == 0)
            {
                converted += "Buzz";
            }

            if (converted.Length == 0)
            {
                converted = n.ToString();
            }

            return converted;
        }
    }
}
