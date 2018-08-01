using NumericConversion.Application.Extensions;
using Xunit;

namespace NumericConversion.Application.Tests.Extensions
{
    public class ObjectExtensionTests
    {
        [Fact]
        public void ChangeType_StringToInt_ReturnsNewObject()
        {
            const string stringValue = "123";

            Assert.Equal(123, stringValue.ChangeTypeTo<int>());
        }

        [Fact]
        public void ChangeType_IntToString_ReturnsNewObject()
        {
            const int intValue = 123;

            Assert.Equal("123", intValue.ChangeTypeTo<string>());
        }
    }
}