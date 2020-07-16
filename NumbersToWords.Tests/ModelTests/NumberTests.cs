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
      Number newNumber = new Number();
      Assert.AreEqual(typeof(Number), newNumber.GetType());
    }

  }
}