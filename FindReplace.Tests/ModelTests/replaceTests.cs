using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using FindReplace.Models;

namespace FindReplace.Tests
{
  [TestClass]
  public class ReplaceTests : IDisposable
  {
    public void Dispose()
    {
      Replace.ClearAll();
    }

    [TestMethod]
    public void Log_Input()
    {
      string text = "hello there";
      string outgoingWord = "hello";
      string incomingWord = "goodbye";
      Replace test = new Replace(text, outgoingWord, incomingWord);
      Assert.AreEqual(typeof(Replace), test.GetType());
      Assert.AreEqual("hello", test.OutgoingWord);
    }
    
    [TestMethod]
    public void SplitTextIntoList_SplitTextIntoList_List()
    {
      string text = "hello there";
      string outgoingWord = "hello";
      string incomingWord = "goodbye";
      Replace test = new Replace(text, outgoingWord, incomingWord);
      List<string> testList = new List<string>{"hello", "there"};
      List<string> wordList = test.SplitTextIntoList();
      CollectionAssert.AreEqual(wordList, testList);
    }

    [TestMethod]
    public void ReplaceWordReturnString_ReplaceWordReturnString_String()
    {
      string text = "hello there";
      string outgoingWord = "hello";
      string incomingWord = "goodbye";
      Replace test = new Replace(text, outgoingWord, incomingWord);
      string testString = "goodbye there";
      Assert.AreEqual(testString, test.ReplaceWordReturnString());
    }

    [TestMethod]
    public void ReplaceWordReturnString_ReplacePartialWordReturnString_String()
    {
      string text = "I am walking my cat to the cathedral";
      string outgoingWord = "cat";
      string incomingWord = "dog";
      Replace test = new Replace(text, outgoingWord, incomingWord);
      string testString = "I am walking my dog to the doghedral";
      Assert.AreEqual(testString, test.ReplaceWordReturnString());
    }
  }
}


// Example test format:

/*

[TestMethod]
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

 */