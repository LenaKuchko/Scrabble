using System.Collections.Generic;
using System.IO;
using System;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    public char [] ConvertString(string word)
    {
      char [] wordArray = new char [word.Length];
      wordArray = word.ToLower().ToCharArray();
      Console.WriteLine(wordArray);
      return wordArray;
    }
    public int GetScore(char [] wordArray)
    {
      int count = 0;
      for(int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == 'a' || wordArray[i] == 'e' ||  wordArray[i] == 'i' ||  wordArray[i] == 'o' ||  wordArray[i] == 'u' ||  wordArray[i] == 'l' ||  wordArray[i] == 'n' ||  wordArray[i] == 'r' ||  wordArray[i] == 's' ||  wordArray[i] == 't')
        {
          count += 1;
        }
        else if ( wordArray[i] == 'd' ||  wordArray[i] == 'g')
        {
          count += 2;
        }
        else if ( wordArray[i] == 'b' ||  wordArray[i] == 'c' ||  wordArray[i] == 'm' ||  wordArray[i] == 'p')
        {
          count += 3;
        }
        else if ( wordArray[i] == 'f' ||  wordArray[i] == 'h' ||  wordArray[i] == 'v' ||  wordArray[i] == 'w' ||  wordArray[i] == 'y' )
        {
          count += 4;
        }
        else if ( wordArray[i] == 'k')
        {
          count += 5;
        }
        else if ( wordArray[i] == 'j' ||  wordArray[i] == 'x' )
        {
          count += 8;
        }
        else if ( wordArray[i] == 'q' ||  wordArray[i] == 'z' )
        {
          count += 10;
        }
        else
        {
          count += 0;
        }
      }
      Console.WriteLine(count);
      return count;
    }
  }
}
