using System;
using System.Collections.Generic;

namespace ConvertLibrary
{
    public class Class1
    {
        public static List<int> Convert(char[] gap)
        {
            List<int> convert = new List<int>();
            for (int i = 0; i < gap.Length; i++)
            {
                if (char.IsNumber(gap[i]))
                {
                    convert.Add(gap[i] - '0');
                }
            }

            return convert;
        }
    }
}
