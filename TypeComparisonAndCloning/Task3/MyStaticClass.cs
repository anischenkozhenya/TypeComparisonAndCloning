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
            url = url.Replace(new Regex(keyValueParameter.Split('=')[0]) + "=[^&]*", keyValueParameter);
            return url + (url.IndexOf(keyValueParameter) >= 0 ? "": (url.IndexOf('?') >= 0 ?'&':'?')+keyValueParameter);
        }
    }
}

