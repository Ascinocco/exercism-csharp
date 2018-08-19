using System;
using System.Collections.Generic;
using System.Linq;
//using Sys;

public class Robot
{
    private static List<string> usedNames;

    private string buildName()
    {
        Random random = new Random();
        const string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        const string robotNameAlpha = new String(
            Enumerable
                .Repeat(alpha, 2)
                .Select(s => s[random.Next(s.Length)]).ToArray()
        );
        const string robotNameNumeric = new String(
            Enumerable
            .Repeat(numbers, 3)
            .Select(s => s[random.Next(s.Length)]).ToArray()
        );
        return robotNameAlpha + robotNameNumeric;
    }

    private bool validateName(string name)
    {
        string result = usedNames.Find(n => n == name);
        if (result) return true;
        return false;
    }

    public string Name
    {
        get
        {
            bool nameIsValid = false;
            string robotName;
            while (nameIsValid == false)
            {
                robotName = this.buildName();
                nameIsValid = this.validateName(robotName);
            }
            return robotName;
        }
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}