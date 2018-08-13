using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Pangram
{
    private static readonly int ALPHABET_LETTER_COUNT = 26;

    public static bool IsPangram(string input)
    {
        string parsedInput = getParsedString(input);
        return parsedInput.Length >= ALPHABET_LETTER_COUNT;
    }
    public static string getParsedString(string input)
    {
        string alphaString = stripNonAlphaCharacters(input.ToLower());
        return removeDuplicateLetters(alphaString);
    }

    public static string stripNonAlphaCharacters(string input)
    {
        Regex stripCharsRgx = new Regex("[^a-z]");
        return stripCharsRgx.Replace(input, "");
    }

    public static string removeDuplicateLetters(string input)
    {
        string lowerCaseInput = input.ToLower();
        string result = "";
        foreach(char value in lowerCaseInput)
        {
            if (result.IndexOf(value) == -1)
            {
                result += value;
            }
        }

        return result;
    }
}
