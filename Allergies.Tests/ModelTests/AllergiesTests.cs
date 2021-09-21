using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergies;
using System;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergiesTests
  {
    [TestMethod]
    public void GetAllergies_AddAllergies_OneElement()
    {
      string[] testArray = new string[1] {"eggs"};
      Assert.AreEqual(testArray[0], Allergies.GetAllergies(1)[0]);
    }
  }
}