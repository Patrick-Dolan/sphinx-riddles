using System;
using System.Collections.Generic;

namespace Riddles.RiddleBook
{
  public class Riddle
  {
    public string RiddleQuestion { get; set; }
    public string RiddleAnswer { get; set; }
    public Riddle(string riddle, string answer)
    {
      RiddleQuestion = riddle;
      RiddleAnswer = answer;
    }

    public static int RandomRiddle(List<Riddle> riddles)
    {
      Random r = new Random();
      int riddleNumber = r.Next(0, riddles.Count);
      return riddleNumber;
    }
  }
}