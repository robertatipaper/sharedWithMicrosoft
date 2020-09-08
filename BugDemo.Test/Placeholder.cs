using System;
using FluentAssertions;
using Xunit;

namespace BugDemo.Test
{
  public class Placeholder
  {
    [Fact]
    public void PlaceHold()
    {
      1.Should().Be(1);
    }
  }
}
