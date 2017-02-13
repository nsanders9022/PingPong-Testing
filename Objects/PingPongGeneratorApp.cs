using System.Collections.Generic;
using System;

namespace PingPong.Objects
{
  public class PingPongGeneratorApp
  {
    private int _number;
    private static List<string> _instances = new List<string>{};

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

    public static void DeleteAll()
    {
      _instances.Clear();
    }

    public List<string> PingPongResult(int number)
    {
      List<string> result = new List<string> {};
      for (int i = 1; i <= number; i++)
      {
        if (i % 15 == 0)
        {
          result.Add("pingpong");
        }
        else if (i % 3 == 0)
        {
          result.Add("ping");
        }
        else if (i % 5 == 0)
        {
            result.Add("pong");
        }
        else
        {
          result.Add(i.ToString());
        }
      }
      return result;
    }
  }
}
