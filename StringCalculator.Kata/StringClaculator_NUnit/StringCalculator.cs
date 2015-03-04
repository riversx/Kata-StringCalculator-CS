using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringClaculator.Kata
{
    class StringCalculator
    {
        internal int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            int value = int.Parse(numbers);
            if (value < 0)
                throw new Exception("Negative numbers are not allowed!");
            return value;
        }



    }
}
