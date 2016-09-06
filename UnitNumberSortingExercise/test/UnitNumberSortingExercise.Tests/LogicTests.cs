using System;
using System.Text;
using UnitNumberSortingExercise.Logic;
using Xunit;

namespace UnitNumberSortingExercise.Tests
{
    public class LogicTests
    {
        [Fact]
        public void SanityCheck()
        {
            Assert.True(true);
        }

        [Fact]
        public void SortByNumberNoSort()
        {
            var sb = new StringBuilder();
            sb.Append("#1 - Hartnell\n");
            sb.Append("#2 - Troughton\n");
            var data = sb.ToString();
            var result = Logic.Logic.Sort(data);
            Assert.Equal(data, result);
        }

        [Fact]
        public void SortByNumberWho()
        {
            var sb = new StringBuilder();
            sb.Append("#2 - Troughton\n");
            sb.Append("#1 - Hartnell\n");
            var data = sb.ToString();
            var result = Logic.Logic.Sort(data);

            var sbExpected = new StringBuilder();
            sbExpected.Append("#1 - Hartnell\n");
            sbExpected.Append("#2 - Troughton\n");
            var expectedResult = sbExpected.ToString();

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SortByNumber()
        {
            var sb = new StringBuilder();
            sb.Append("#50 - Smith\n");
            sb.Append("#8 - Johnson\n");
            var data = sb.ToString();
            var result = Logic.Logic.Sort(data);

            var sbExpected = new StringBuilder();
            sbExpected.Append("#8 - Johnson\n");
            sbExpected.Append("#50 - Smith\n");
            var expectedResult = sbExpected.ToString();

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void SortByLetter()
        {
            var sb = new StringBuilder();
            sb.Append("#1B - Adams\n");
            sb.Append("#1A – Kessenich\n");
            var data = sb.ToString();
            var result = Logic.Logic.Sort(data);

            var sbExpected = new StringBuilder();
            sbExpected.Append("#1A – Kessenich\n");
            sbExpected.Append("#1B - Adams\n");
            var expectedResult = sbExpected.ToString();

            Assert.Equal(expectedResult, result);
        }
    }
}
