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
      allergies.Add(1, "eggs"); //2^0
      allergies.Add(2, "peanuts"); //2^1
      allergies.Add(4, "shellfish"); //2^2
      allergies.Add(8, "strawberries"); //2^3
      allergies.Add(16, "tomatoes");
      allergies.Add(32, "chocolate");
      allergies.Add(64, "pollen");
      allergies.Add(128, "cats");
      string[] results = new string[2];
      for (int i = 0; i <= 8; i++){
        results[i] = allergies[Convert.ToInt32(Math.Pow(2, i))];
      }
      return results;
    }
    
    
  }
}
