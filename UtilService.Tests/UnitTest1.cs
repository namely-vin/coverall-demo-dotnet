using System;
using Xunit;

namespace UtilService.Tests
{
    public class OneDistanceAwayTest
    {
        [Fact]
        public void It_Should_Return_True_If_Same_String()
        {
            var isOneAway = Util.OneEditAway("test", "test");
            Assert.True(isOneAway);
        }
    }
}
