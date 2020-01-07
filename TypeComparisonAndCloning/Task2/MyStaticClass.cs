using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class MyStaticClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstArg">The original string to be converted</param>
        /// <param name="secondArg">Space-delimited list of minor words that must always be lowercase except for the first word in the string</param>
        /// <returns>New converted string</returns>
        public static string TitleCase(string firstArg, string secondArg = "")
        {
            if (firstArg == null || secondArg == null)
            {
                throw new ArgumentNullException();
            }
            string[] minorWordList = secondArg.ToLower().Split(' ');
            string[] wordsOriginalString = firstArg.ToLower().Trim().Split(' ');
            string result = "";
            for (int i = 0; i < wordsOriginalString.Length; i++)
            {
                if (Array.Exists(minorWordList, x => x == wordsOriginalString[i]))
                {
                    result += wordsOriginalString[i];
                }
                else
                {
                    if (wordsOriginalString[i].Length > 1)
                    {
                        result += wordsOriginalString[i].Substring(0, 1).ToUpper() + wordsOriginalString[i].Substring(1, wordsOriginalString[i].Length - 1);
                    }
                    else
                    {
                        wordsOriginalString[i].ToUpper();
                    }
                }
                result += " ";
            }
            return (result.Substring(0, 1).ToUpper() + result.Substring(1, result.Length - 1)).Trim();
        }
    }

}
