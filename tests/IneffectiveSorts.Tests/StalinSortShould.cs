using IneffectiveSorts.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace IneffectiveSorts.Tests
{
    public class StalinSortShould
    {
        [Fact]
        public void ReturnEmptyIfNull()
        {
            var sorted = new StalinSort().Sort(null);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void ReturnEmptyIfEmpty()
        {
            var sorted = new StalinSort().Sort(new int[0]);

            Assert.Equal(new int[0], sorted);
        }

        [Theory, MemberData(nameof(Data))]
        public void Sort(int[] expected, int[] given)
        {
            var sorted = new StalinSort().Sort(given);

            Assert.Equal(expected, sorted);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new[] { 1, 2, 5 },
                        new[] { 1, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 10 },
                        new[] { 10, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 1, 2, 3, 5 },
                        new[] { 1, 2, 3, 2, 5 }
                    },
                    new object[] {
                        new[] { 1, 2000 },
                        new[] { 1, 2000, 3, 2, 500 }
                    }
                };
            }
        }
    }
}
