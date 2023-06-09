using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class CamelCase2
    {
        public static string ToCamelCase(string str)
        {
            string[] list = str.Split(new char[] { '-', '_' });

            for (int i = 1; i < list.Length; i++)
            {
                list[i] = new CultureInfo("en-US", false).TextInfo.ToTitleCase(list[i]);
            }

            return string.Concat(list);
        }
    }
}
