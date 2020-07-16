using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class Number
  {
    public int UserNumber { get; }
    public Number(int inputNumber)
    {
      UserNumber = inputNumber;
    }

    public string NumberToWords()
    {
      Dictionary<int, string> numberToWordConverter = new Dictionary<int, string>() {
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
        {90, "ninety"}
      };

      List<string> outputList = new List<string> {};
      int currentNumber = UserNumber;
      while (currentNumber > 0)
      {
        int highestValue = 0;
        foreach(KeyValuePair<int, string> entry in numberToWordConverter)
        {
          if (entry.Key <= currentNumber)
          {
            highestValue = entry.Key;
          }
        }
        outputList.Add(numberToWordConverter[highestValue]);
        currentNumber -= highestValue;
      }
      string output = String.Join(" ", outputList);
      return output;
    }
  }
}