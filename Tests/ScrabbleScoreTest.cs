using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class ScrabbleTests
  {
    [Fact]
    public void Get_Right_Array()
    {
      Scrabble newScrabble = new Scrabble();
      char [] testArray = new char[] {'h', 'e', 'l', 'l', 'o'};
      char [] resultArray = newScrabble.ConvertString("hello");
      Assert.Equal(testArray, resultArray);
    }
    [Fact]
    public void Convert_StringTo_Score()
    {
      Scrabble newScrabble = newScrabble();
      int testScore = 5;
      int resultScore = newScrabble.GetScore(newScrabble.ConverString("hello"));
    }
  }
}
