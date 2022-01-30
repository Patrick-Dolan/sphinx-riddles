using System;
using System.Collections.Generic;
using Riddles.RiddleBook;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle firstRiddle = new Riddle("What month of the year has 28 days?", "all of them");
      Riddle secondRiddle = new Riddle("What has to be broken before you can use it?", "an egg");
      Riddle thirdRiddle = new Riddle("What is full of holes but still holds water", "a sponge");
      Riddle fourthRiddle = new Riddle("What is always in front of you but can't be seen?", "the future");
      Riddle fifthRiddle = new Riddle("What goes up but never comes down?", "your age");
      
      List<Riddle> riddles = new List<Riddle>() { firstRiddle, secondRiddle, thirdRiddle, fourthRiddle, fifthRiddle };
      int riddleNumber = Riddle.RandomRiddle(riddles);
      Console.WriteLine("The Sphinx has a riddle for you. Answer correctly or else...");
      Console.WriteLine(riddles[riddleNumber].RiddleQuestion);
      string answer = Console.ReadLine().ToLower();
      
      if (answer == riddles[riddleNumber].RiddleAnswer)
      {
        Console.WriteLine("You answered the correctly and get to live... For now...");
      }
      else
      {
        Console.WriteLine("You answered incorrectly and are swallowed hole by the Sphinx. Better luck next time.");
      }
    }
  }
}