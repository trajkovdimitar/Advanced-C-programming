using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
   public static class Extensions
    {
        public static bool IsPalindrom<T>(this T text)
        {
            string forwards = text.ToString().ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (var item in forwards)
            {
                if (Char.IsLetterOrDigit(item))
                {
                    sb.Append(item);
                }                
            }
            forwards = sb.ToString();
            char[] chars = forwards.ToCharArray();
            Array.Reverse(chars);
            string backwards = new string(chars);
            return backwards == forwards;
        }
        
    }
}
