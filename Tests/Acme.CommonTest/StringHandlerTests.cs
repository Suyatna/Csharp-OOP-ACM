using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTests
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            // arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();
            
            // act
            var actual = handler.InsertSpaces(source);
            
            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            // arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();
            
            // actual
            var actual = handler.InsertSpaces(source);
            
            // assert
            Assert.Equal(expected, actual);
        }
    }
}