using System;
using Xunit;
using Xunit.Sdk;
using System.Collections.Generic;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
          

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017, 0D, "")]
        public void ShouldParse(string str, double longt, double lat, string name)
        {
            // - FINISHED - : Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            TacoParser sut = new TacoParser();


            //Act
            var actual = sut.Parse(str);

            //Assert
            Assert.Equal(longt, actual.Location.Latitude);
            Assert.Equal(lat, actual.Location.Latitude);
            Assert.Equal(name, actual.Name);

        }


        // - FINISHED -: Create a test that fails parse
        [Theory]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            // Arrange
            TacoParser sut = new TacoParser();

            // Act
            var actual = sut.Parse(str);

            //Assert
            Assert.Null(actual);
        }

    }
}
