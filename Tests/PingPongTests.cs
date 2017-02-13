using Xunit;
using PingPong.Objects;
using System;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPongTest : IDisposable
  {
    [Fact]
    public void PingPongResult_PrintNumbers_numbers()
    {
      PingPongGeneratorApp testNumbers = new PingPongGeneratorApp();
      List<string> expectedResult = new List<string>{"1","2"};
      Assert.Equal(expectedResult, testNumbers.PingPongResult(2));
    }
    [Fact]
    public void PingPongResult_Ping_numberPing()
    {
      PingPongGeneratorApp testPing = new PingPongGeneratorApp();
      List<string> expectedResult = new List<string>{"1", "2", "ping"};
      Assert.Equal(expectedResult, testPing.PingPongResult(3));
    }

    public void Dispose()
    {
       PingPongGeneratorApp.DeleteAll();
    }


  }
}
