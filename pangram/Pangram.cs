using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


// @TODO: Anthony - Check the tests, there are certain edge cases you need to handle
// underscores, numbers, etc
public static class Pangram
{
    private static readonly char[] Alphabet = new char[]
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    private static char[] filterInput (char[] inputChars)
    {
      var filteredInputChars = inputChars.Where(
        x => !string.IsNullOrEmpty(x.ToString()) && x.GetType() == typeof(char)
      );
      return filteredInputChars.ToArray<char>();
    }

    // @TODO: Anthony - setup regex to strip all disallowed characters. 
  public static bool IsPangram(string input)
  {
    string parsedInput = getStrippedString(input);
    var inputChars = input.ToLower().ToArray();
    var filteredInputChars = filterInput(inputChars);
        if (filteredInputChars.Length < Alphabet.Length) return false;
        List<char> foundLetters = new List<char>();
        foreach (char inputChar in filteredInputChars)
        {
            char lowerCaseChar = char.ToLower(inputChar);
            var found = foundLetters.Contains(lowerCaseChar);
            if (!found) foundLetters.Add(lowerCaseChar);
        }
        return foundLetters.Count == Alphabet.Length;
    }

  public static string getStrippedString(string input)
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
