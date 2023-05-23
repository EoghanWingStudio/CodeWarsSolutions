using System;

public class Kata
{
    public static void Main()
    {

    }
    public static int DuplicateCount(string str)
    {
        str = str.ToLower();

        List<char> chars= new List<char>();
        chars.AddRange(str);

        foreach(char c in chars)
        {
            if (str.Any(x => x == c)) ;
        }

        return -1;
    }
}