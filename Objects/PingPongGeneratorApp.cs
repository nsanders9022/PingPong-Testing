using System.Collections.Generic;
using System;

namespace PingPong.Objects
{
  public class PingPongGeneratorApp
  {
    private int _number;

    public void PingPongGenerator(int number)
    {
      _number = number;
    }

    public int GetNumber()
    {
      return _number;
    }

    public void SetNumber(int aNumber)
    {
      _number = aNumber;
    }

    public List<int> PingPongResult(int number)
    {
      List<int> result = new List<int> {};
      for (int i = 1; i <= number; i++)
      {
        result.Add(i);
      }
      return result;
    }

  }
}
