using System;
using System.Collections.Generic;

namespace Allergies
{
  public class Allergies
  {
    public static string[] GetAllergies(int n)
    {
      //need reference data hardcoded
      Dictionary<int, string> allergies = new   Dictionary<int, string>();
      allergies.Add(1, "eggs");
      string[] results = new string[8];
      results[0] = allergies[n];
      return results;
    }
    
    
  }
}
