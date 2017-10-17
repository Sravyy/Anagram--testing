using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramApp;
using System;

namespace AnagramApp.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void IsAnagram_NotEqualLength_False()
    {
        Anagram testAnagram = new Anagram();
        Assert.AreEqual(false, testAnagram.IsAnagram("ead","dread"));
    }
    [TestMethod]
    public void IsAnagram_SameCharsWithSpaces_False()
    {
        Anagram testAnagram = new Anagram();
        Assert.AreEqual(false, testAnagram.IsAnagram("beard","br ad"));
    }
    [TestMethod]
    public void IsAnagram_SameChars_True()
    {
        Anagram testAnagram = new Anagram();
        Assert.AreEqual(true, testAnagram.IsAnagram("beard","bread"));
    }
    [TestMethod]
    public void IsAnagram_DiffChars_False()
    {
        Anagram testAnagram = new Anagram();
        Assert.AreEqual(false, testAnagram.IsAnagram("beard","dread"));
    }
  }
}
