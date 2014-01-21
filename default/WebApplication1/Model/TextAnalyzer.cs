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
            int myCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i])) {
                    myCount++;
                }
            }
            return myCount;
        }
    }
}