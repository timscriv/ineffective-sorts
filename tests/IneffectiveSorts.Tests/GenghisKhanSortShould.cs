using IneffectiveSorts.Core;
using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace IneffectiveSorts.Tests
{
    public class GenghisKhanSortShould
    {
        [Fact]
        public void ReturnEmptyIfNull()
        {
            var sorted = new GenghisKhanSort().Sort(null);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void ReturnEmptyIfEmpty()
        {
            var sorted = new GenghisKhanSort().Sort(new int[0]);

            Assert.Equal(new int[0], sorted);
        }

        [Theory, MemberData(nameof(Data))]
        public void Sort(int[] expected, int[] given)
        {
            var sorted = new GenghisKhanSort().Sort(given);

            Assert.Equal(expected, sorted);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new[] { 1, 2, 3, 4, 5 },
                        new[] { 1, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 10, 11, 12, 13, 14 },
                        new[] { 10, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 13582045, 13582046, 13582047, 13582048, 13582049 },
                        new[] { 13582045, 2, 5, 4, 3 }
                    }
                };
            }
        }
    }
}
