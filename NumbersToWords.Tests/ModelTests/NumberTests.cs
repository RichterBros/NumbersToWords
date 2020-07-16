using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ClassTests
  {

    [TestMethod]
    public void NumberConstructor_CreatesInstanceOfNumber_Number()
    {
      Number newNumber = new Number(10);
      Assert.AreEqual(typeof(Number), newNumber.GetType());
    }

    [TestMethod]
    public void GetNumber_ReturnsNumber_Int()
    {
      int testNumber = 10;
      Number newNumber = new Number(10);
      int resultNumber = newNumber.UserNumber;
      Assert.AreEqual(testNumber, resultNumber);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberLessThan20_String()
    {
      string testString = "fourteen";
      Number newNumber = new Number(14);
      string resultString = newNumber.NumberToWords();
      Assert.AreEqual(testString, resultString);
    }

  }
}