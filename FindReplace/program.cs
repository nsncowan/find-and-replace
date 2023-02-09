using FindReplace.Models;
using System;

namespace FindReplaceFrontEnd
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a sentence.");
      string text = Console.ReadLine();
      Console.WriteLine("Please tell us which word you want to replace.");
      string outgoingWord = Console.ReadLine();
      Console.WriteLine("What do you want to replace it with?");
      string incomingWord = Console.ReadLine();

      Replace test = new Replace(text, outgoingWord, incomingWord);
      string output = test.ReplaceWordReturnString();
      Console.WriteLine(output);
    }
  }
}