using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task3
{
    public static class MyStaticClass
    {
        /// <summary>
        /// Method add or change Url with parameter
        /// </summary>
        /// <param name="url">Original Url</param>
        /// <param name="keyValueParameter">New parameters</param>
        /// <returns>New Url with new parametrs</returns>
        public static string AddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            if (url == null || keyValueParameter == null)
            {
                throw new ArgumentNullException();
            }
            string patternKeyValue = @"(?<key>[a-zA-Z0-9]*)=(?<value>[a-zA-Z0-9]*)";
            string patternLink = @"^([a-zA-Z0-9.:\/]*)+?";
            StringBuilder link = new StringBuilder(new Regex(patternLink).Match(url).Value);
            var keyValueUrl = new Regex(patternKeyValue).Matches(url);
            var KeyValueParam = new Regex(patternKeyValue).Matches(keyValueParameter);
            Dictionary<string, string> keyValuesUrlDictionary = new Dictionary<string, string>();
            foreach (Match item in keyValueUrl)
            {
                keyValuesUrlDictionary.Add(item.Groups["key"].Value, item.Groups["value"].Value);
            }
            Dictionary<string, string> keyValuesParamDictionary = new Dictionary<string, string>();
            foreach (Match item in KeyValueParam)
            {
                keyValuesParamDictionary.Add(item.Groups["key"].Value, item.Groups["value"].Value);
            }
            if (keyValuesParamDictionary.Count > 0)
            {
                foreach (var i in keyValuesParamDictionary)
                {
                    if (keyValuesUrlDictionary.ContainsKey(i.Key))
                    {
                        keyValuesUrlDictionary[i.Key] = i.Value;
                    }
                    else
                    {
                        keyValuesUrlDictionary.Add(i.Key, i.Value);
                    }
                }
            }
            if (keyValuesUrlDictionary.Count > 0)
            {
                link.Append("?");
                foreach (var i in keyValuesUrlDictionary)
                {
                    link.Append(i.Key + "=" + i.Value + "&");
                }
                
                link.Remove(link.Length-1,1);
            }
            return link.ToString();
        }
    }
}
