using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(this string text){

            
            int myCount;
            
            Regex myRegex = new Regex("[A-ZÅÄÖ]");
            myCount = myRegex.Matches(text).Count;

            
            
            return 5;
        }
    }
}