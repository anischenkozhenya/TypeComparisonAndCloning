using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task6
{
    public class MyStaticClass
    {
        /// <summary>
        /// Return sum of two biggest numbers(number double)
        /// </summary>
        /// <param name="stringWithNumbers">String with numbers</param>
        /// <returns>Sum of two biggest numbers</returns>
        public static string SumTwoBiggestNumbers(string stringWithNumbers)
        {
            if (stringWithNumbers == null)
            {
                throw new ArgumentNullException();
            }
            List<double> ListWithNumbers = new List<double>();
            foreach (Match i in new Regex("(?<number>[0-9]+[\\,][0-9])|(?<number>[0-9]+)").Matches(stringWithNumbers))
            {
                ListWithNumbers.Add(Convert.ToDouble(i.Groups["number"].Value));
            }
            if (ListWithNumbers.Count < 2)
            {
                throw new ArgumentException();//("Count of numbers is less than 2");
            }
            ListWithNumbers = ListWithNumbers.OrderByDescending(x => x).ToList();
            double result;
            try
            {
                checked
                {
                    result = ListWithNumbers[0] + ListWithNumbers[1];
                }
            }
            catch (OverflowException)
            {
                throw new OverflowException("Sum overflow");
            }
            return result.ToString();
        }
    }
}
