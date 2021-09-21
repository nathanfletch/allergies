using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies;
using System;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    // [TestMethod]
    // public void GetAllergies_AddAllergies_OneElement()
    // {
    //   string[] testArray = new string[1] {"eggs"};
    //   CollectionAssert.AreEqual(testArray, Allergies.GetAllergies(1));
    // }
    [TestMethod]
    public void GetAllergies_AddAllergies_TwoElements()
    {
      string[] testArray = new string[2] {"eggs", "peanuts"};
      CollectionAssert.AreEqual(testArray, Allergies.GetAllergies(2));
    }
  }
}