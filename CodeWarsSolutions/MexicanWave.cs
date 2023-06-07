using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public static class MexicanWave
    {
        public static List<string> wave(string str)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                char[] chars = str.ToCharArray();
                if (chars[i] == ' ') continue;

                chars[i] = char.ToUpper(chars[i]);
                string mexicanWave = new string(chars);
                list.Add(mexicanWave);
            }



            return list;
        }
    }
}
