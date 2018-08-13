using System;
using System.Linq;
public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] reversedChars = input.ToCharArray().Reverse().ToArray();
        return new string(reversedChars);
    }
}
