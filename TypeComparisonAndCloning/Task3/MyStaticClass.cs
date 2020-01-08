using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    public static class MyStaticClass
    {
        public static string AddOrChangeUrlParameter(string url, string keyValueParameter)
        {
            if (url == null || keyValueParameter == null)
            {
                throw new ArgumentNullException();
            }
            //url = Regex.Replace(url,keyValueParameter.Split('=')[0]+@"=[^&]*", keyValueParameter);
            //return url + (url.IndexOf(keyValueParameter) >= 0 ? "": (url.IndexOf('?') >= 0 ?"&":"?") + keyValueParameter);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string patternKeyValue = @"(?<key>[a-zA-Z0-9]*)=(?<value>[a-zA-Z0-9]*)";
            string patternLink = @"^([a-zA-Z0-9.:\/]*)+?";
            string link = new Regex(patternLink).Match(url).Value;
            var keyValueUrl = new Regex(patternKeyValue).Matches(url);
            var KeyValueParam = new Regex(patternKeyValue).Matches(keyValueParameter);
            int n = keyValueUrl.Count;
            Dictionary<string, string> keyValuesUrlDictionary = new Dictionary<string, string>();
            foreach (Match item in keyValueUrl)
            {
                keyValuesUrlDictionary.Add(item.Groups["key"].Value,item.Groups["value"].Value);
            }
            Dictionary<string, string> keyValuesParamDictionary = new Dictionary<string, string>();
            foreach (Match item in KeyValueParam)
            {
                keyValuesParamDictionary.Add(item.Groups["key"].Value, item.Groups["value"].Value);
            }
            if (keyValuesParamDictionary.Count>0)
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
            if (keyValuesUrlDictionary.Count>0)
            {
                link+= "?";
                foreach (var i in keyValuesUrlDictionary)
                {
                    link += i.Key + "=" + i.Value + "&";
                }
                link = link.Substring(0, link.Length - 1);
            }
            return link;

        }
    }
}

