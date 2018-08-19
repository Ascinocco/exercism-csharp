using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Robot
{
    private static List<string> UsedRobotNames = new List<string>();

    private Random Generator = new Random();

    private int NumberOfAlphaCharsNeeded = 2;

    private readonly char[] Aplhabet = new char[]
    {
        'A','B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
        'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
        'W', 'X', 'Y', 'Z'
    };

    private readonly char[] Numbers = new char[]
    {
        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
    };

    private string BuildName()
    {
        char[] NewName = new char[5];
        for (int i = 0; i < 5; i++)
        {
            if (i <= this.NumberOfAlphaCharsNeeded) {
                int alphaPos = this.Generator.Next(0, this.Aplhabet.Length);
                NewName[i] = this.Aplhabet[alphaPos];
            }

            int numericPos = this.Generator.Next(0, this.Numbers.Length);
            NewName[i] = this.Numbers[numericPos];
        }
        return NewName.ToString();
    }

    private bool ValidateName(string RobotName)
    {
        Regex RobotNameValidator = new Regex(@"[A-Z]{2}\d{3}");
        bool NameIsValid = RobotNameValidator.IsMatch(RobotName);
        //Console.WriteLine(RobotName);
        if (!NameIsValid) return false;
        bool FoundName = UsedRobotNames.Contains(RobotName);
        if (FoundName) return false;
        return true;
    }

    public string GetName()
    {
        string GeneratedName = this.BuildName();
        Console.WriteLine(GeneratedName);
        bool NameIsValid = this.ValidateName(GeneratedName);
        if (!NameIsValid) this.GetName();
        UsedRobotNames.Add(GeneratedName);
        return GeneratedName;
    }

    public string Name;

    public Robot()
    {
        this.Name = this.GetName();
    }

    public void Reset()
    {
        this.Name = this.GetName();
    }
}