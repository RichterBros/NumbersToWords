using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Number
  {
    public long UserNumber { get; }
    public Number(long inputNumber)
    {
      UserNumber = inputNumber;
    }

    public static string NumberToWords(long inputNumber)
    {
      Dictionary<long, string> numberToWordConverter = new Dictionary<long, string>() {
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"},
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "fifteen"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"},
        {20, "twenty"},
        {30, "thirty"},
        {40, "fourty"},
        {50, "fifty"},
        {60, "sixty"},
        {70, "seventy"},
        {80, "eighty"},
        {90, "ninety"},
        {100, "hundred"},
        {1000, "thousand"},
        {1000000, "million"},
        {1000000000, "billion"},
        {1000000000000, "trillion"},
      };

      List<string> outputList = new List<string> {};
      long currentNumber = inputNumber;
      while (currentNumber > 0)
      {
        long highestValue = 0;
        foreach(KeyValuePair<long, string> entry in numberToWordConverter)
        {
          if (entry.Key <= currentNumber)
          {
            highestValue = entry.Key;
          }
        }
        if (highestValue >= 100)
        {
          decimal val = currentNumber / highestValue;
          long multiple = (long)Math.Floor(val);
          outputList.Add(Number.NumberToWords(multiple));
          outputList.Add(numberToWordConverter[highestValue]);
          currentNumber -= multiple * highestValue;
        }
        else 
        {
          outputList.Add(numberToWordConverter[highestValue]);
          currentNumber -= highestValue;
        }
      }
      string output = String.Join(" ", outputList);
      return output;
    }
  }
}