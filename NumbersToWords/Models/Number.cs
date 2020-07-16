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
  }
}