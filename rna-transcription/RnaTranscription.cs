using System;
using System.Collections.Generic;

public static class Rna
{
  private static readonly Dictionary<char, char> DnaToRnaMap = new Dictionary<char, char>
  {
    {'G', 'C'},
    {'C', 'G'},
    {'T', 'A'},
    {'A', 'U'},
  };
  public static List<char> ConvertToRna(char[] dna)
  {
    List<char> convertedRna = new List<char>();
    foreach(char dnaSequenceItem in dna)
    {
      var convertedItem = DnaToRnaMap[dnaSequenceItem];
      convertedRna.Add(convertedItem);
    }
    return convertedRna;
  }

  public static string GetRnaString(List<char> rna)
  {
    return string.Join("", rna.ToArray());
  }
}

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] nucleotideArray = nucleotide.ToCharArray();
        List<char> rnaList = Rna.ConvertToRna(nucleotideArray);
        var temp = Rna.GetRnaString(rnaList);
        Console.WriteLine(temp);
        return temp;
    }
}
