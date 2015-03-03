using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculator_MSTest
{
    class StringCalculator
    {

        private List<string> negatives = new List<string>();

        internal int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            string[] values = ExtractValuesOnly(numbers);
            return SumMultipleValues(values);
        }

        private string[] ExtractValuesOnly(string numbers)
        {
            char[] separators;
            if (numbers.StartsWith("//"))
            {
                separators = new[] { numbers[2], '\n' };
                numbers = numbers.Substring(4);
            }
            else
                separators = new[] { ',', '\n' };
            return numbers.Split(separators);
        }

        private int SumMultipleValues(string[] values)
        {
            int total = 0;
            foreach (string value in values)
                total += ParseValue(value);
            if (negatives.Count > 0)
                throw new ArgumentException("negatives not allowed: " + String.Join(",", negatives.ToArray()));
            return total;
        }

        private int ParseValue(string value)
        {
            int result = int.Parse(value);
            if (result < 0)
            {
                negatives.Add(value);
                result = 0;
            }
            return result;
        }

    }
}
