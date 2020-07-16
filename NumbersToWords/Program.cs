using System;
using System.Collections.Generic;
using NumbersToWords.Models;

namespace Template {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number!");
      string userInput = Console.ReadLine();
      Console.WriteLine(Number.NumberToWords(long.Parse(userInput)));
    }
  }
}