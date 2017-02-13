using Xunit;
using PingPong.Objects;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPongTest
  {
    [Fact]
    public void PingPongResult_PrintNumbers_numbers()
    {
      PingPongGeneratorApp testNumbers = new PingPongGeneratorApp();
      List<int> expectedResult = new List<int>{1,2};
      Assert.Equal(expectedResult, testNumbers.PingPongResult(2));
    }
  }
}
