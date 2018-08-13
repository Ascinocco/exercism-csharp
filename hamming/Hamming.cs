using System;
using System.Collections.Generic;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
       if (firstStrand.Length != secondStrand.Length)
       {
          throw new ArgumentException("Strand Length Must Match!");
       }

       int hammingItemsCount = 0;
       var firstStrandArray = firstStrand.ToCharArray();
       var secondStrandArray = secondStrand.ToCharArray();
       for(int i = 0; i < firstStrandArray.Length; i++)
       {
          if (firstStrandArray[i] != secondStrandArray[i])
          {
             hammingItemsCount += 1;
          }
       }

        return hammingItemsCount;
    }
}