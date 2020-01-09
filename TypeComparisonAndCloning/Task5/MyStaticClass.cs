using System;
using System.Linq;
using System.Text;

//Complete the solution so that it reverses all of the words
//within the string passed in. Example: 
//ReverseWords("The greatest victory is that which requires no battle")
//=>"battle no requires which that is victory greatest The"


namespace Task5
{
    public static class MyStaticClass
    {
        /// <summary>
        /// Reverse order of words in a string
        /// </summary>
        /// <param name="originalString">Original string</param>
        /// <returns>String with reversed order of words</returns>
        public static string ReverseWords(string originalString)
        {
            if (originalString == null)
            {
                throw new ArgumentNullException();
            }
            StringBuilder result = new StringBuilder();
            foreach (var i in originalString.Split(' ').Reverse())
            {
                result.Append(i + " ");
            }
            return result.ToString().Trim();
        }
    }
}
