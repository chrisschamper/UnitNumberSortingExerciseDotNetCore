using System;
using UnitNumberSortingExercise.Logic;
using Xunit;

namespace Tests
{
    public class UnitNumberTests
    {
        [Fact]
        public void SanityCheck() 
        {
            Assert.True(true);
        }

        [Fact]
        public void UnitNumberStringConstructor()
        {
            var data = "#50 - Smith";
            var unit = new UnitNumber(data);
        }

        [Theory,
        InlineData("#50 - Smith", 50),
        InlineData("#8 - Johnson", 8),
        InlineData("#100 - Sanders", 100),
        InlineData("#1B - Adams", 1),
        InlineData("#1A – Kessenich", 1),
        InlineData("#1A – Johnny 5", 1),
        InlineData("#1A – Henry the 8th", 1),
        InlineData("#1 – Johnny 5", 1),
        InlineData("#1 – Henry the 8th", 1)]
        public void UnitNumberInt(string data, int expectedResult)
        {
            var unit = new UnitNumber(data);
            int roomNumber = unit.RoomNumber;
            Assert.Equal(expectedResult, roomNumber);
        }

        [Theory,
        InlineData("#50 - Smith"),
        InlineData("#8 - Johnson"),
        InlineData("#100 - Sanders")]
        public void UnitNumberLetterNull(string data)
        {
            var unit = new UnitNumber(data);
            string unitLetter = unit.Letter;
            Assert.Equal(String.Empty, unitLetter);
        }

        [Theory,
        InlineData("#1B - Adams", "B"),
        InlineData("#1A – Kessenich", "A")]
        public void UnitNumberLetter(string data, string expectedResult)
        {
            var unit = new UnitNumber(data);
            string unitLetter = unit.Letter;
            Assert.Equal(expectedResult, unitLetter);
        }
    }
}
