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
    [Fact]
    public void PingPongResult_Pong_numberPong()
    {
      PingPongGeneratorApp testPong = new PingPongGeneratorApp();
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4", "pong"};
      Assert.Equal(expectedResult, testPong.PingPongResult(5));
    }

    [Fact]
    public void PingPongResult_PingPong_numberPingPong()
    {
      PingPongGeneratorApp testPingPong = new PingPongGeneratorApp();
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "pingpong"};
      Assert.Equal(expectedResult, testPingPong.PingPongResult(15));
    }

    public void Dispose()
    {
       PingPongGeneratorApp.DeleteAll();
    }


  }
}
