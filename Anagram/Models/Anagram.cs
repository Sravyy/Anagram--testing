using System;
using System.Collections.Generic;

namespace AnagramApp
{
  public class Anagram
  {

    public bool IsAnagram(string a,string b)
    {
      if(a.Length != b.Length)
      {
        return false;
      }
      else
      {
        char[] a1 = a.ToCharArray();
        char[] b1 = b.ToCharArray();
        Array.Sort(a1);
        Array.Sort(b1);

        for (int i = 0; i < a1.Length; i++)
        {
          if (!Array.Equals(a1[i],b1[i]))
          {
            return false;
          }
        }
      }
      return true;
    }
  }
}
