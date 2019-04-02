using System;

namespace ExtensionMethods
{
    public static class Extensions
    {
        public static bool IsPalindrom(this string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        public static bool IsPalindrome(this double num)
        {
            double r, sum = 0, t;
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
                return true;
            else
                return false;
        }
    }
}
