using System;
using System.Linq;

namespace TDD
{
    public class WorkWithDigits
    {
        public int Finding_the_largest_number(string line)
        {
            string str2 = new string(line.Select(x => char.IsDigit(x) ? x : ' ').ToArray());
            int maxLength = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Max(x => x.Length);
            return maxLength;
        }

        public int Num_of_digits(string line)
        {
            return line.Count(char.IsDigit);
        }
    }
}