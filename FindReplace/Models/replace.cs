using System.Collections.Generic;
using System.Linq;

namespace FindReplace.Models
{
  public class Replace
  {
    // properties, constructors, methods, etc. go here
    public string Text;
    public string OutgoingWord{get; set;}
    public string IncomingWord{get; set;}
    public Replace (string text, string outgoingWord, string incomingWord)
    {
      Text = text;
      OutgoingWord = outgoingWord;
      IncomingWord = incomingWord;
    }

    public List<string> SplitTextIntoList()
    {
      List<string> wordList = Text.Split(" ").ToList();
      return wordList;
    }

    public string ReplaceWordReturnString()
    {
      List<string> wordList = SplitTextIntoList();
      //Replace the words in the list
      for (int i=0; i<wordList.Count(); i++)
      {
        if (wordList[i].Contains(OutgoingWord))
        {
          wordList[i] = wordList[i].Replace(OutgoingWord,IncomingWord);
        }
        else 
        {}
      }
      //Put them back together
      return string.Join(" ", wordList);
    } 
    
    public static void ClearAll()
    {
      //do nothing 
    }


  }
}
// In C#, strings can be split into a list of substrings using the Split() method. This method takes in a separator character as a parameter, and split the string around that character. For example, the following code will split the string "Hello World" around the space character, and return a list of two strings: "Hello" and "World":

// string[] words = "Hello World".Split(' ');

// PART 1
// split input into list separated by " "
// gather replacedWord; gather insertWord
// redefine wordList[index of replacedWord] with insertWord


// PART 2
// split input into list separated by " "
// gather replacedWord; gather insertWord
// search using .Contains to find instances of replacedWord WITHIN list indexes
// remove search match from index string
// concatenate insertWord with list index


// replaceWord: world ; insertWord: dog
// worldly => ly => dogly

