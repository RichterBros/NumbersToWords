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
    public void GetNumber_ReturnsNumber_Long()
    {
      long testNumber = 10;
      Number newNumber = new Number(10);
      long resultNumber = newNumber.UserNumber;
      Assert.AreEqual(testNumber, resultNumber);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberLessThan20_String()
    {
      string testString = "fourteen";
      long testNumber = 14;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberGreaterThan20LessThan100_String()
    {
      string testString = "fifty four";
      long testNumber = 54;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberGreaterThan99LessThan1000_String()
    {
      string testString = "five hundred fifty four";
      long testNumber = 554;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberGreaterThan999LessThan1000000_String()
    {
      string testString = "five hundred fifty four thousand five hundred fifty four";
      long testNumber = 554554;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberGreaterThan999999LessThan1000000000_String()
    {
      string testString = "five hundred fifty four million five hundred fifty four thousand five hundred fifty four";
      long testNumber = 554554554;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

    [TestMethod]
    public void NumberToWords_ReturnsWordsForNumberGreaterThan1000000000LessThan999999999999_String()
    {
      string testString = "five hundred fifty four billion five hundred fifty four million five hundred fifty four thousand five hundred fifty four";
      long testNumber = 554554554554;
      string resultString = Number.NumberToWords(testNumber);
      Assert.AreEqual(testString, resultString);
    }

  }
}