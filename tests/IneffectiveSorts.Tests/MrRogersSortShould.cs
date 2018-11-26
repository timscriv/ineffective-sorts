using IneffectiveSorts.Core;
using System;
using System.Collections.Generic;
using Xunit;

namespace IneffectiveSorts.Tests
{
    public class MrRogersSortShould
    {
        [Fact]
        public void ReturnEmptyIfNull()
        {
            var sorted = new MrRogersSort().Sort(null);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void ReturnEmptyIfEmpty()
        {
            var sorted = new MrRogersSort().Sort(new int[0]);

            Assert.Equal(new int[0], sorted);
        }

        [Theory, MemberData(nameof(Data))]
        public void Sort(int[] expected, int[] given)
        {
            var sorted = new MrRogersSort().Sort(given);

            Assert.Equal(expected, sorted);
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new[] { 1, 2, 5, 4, 3 },
                        new[] { 1, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 10, 2, 5, 4, 3 },
                        new[] { 10, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 1, 2, 3, 2, 5 },
                        new[] { 1, 2, 3, 2, 5 }
                    },
                    new object[] {
                        new[] { 1, 2000, 3, 2, 500 },
                        new[] { 1, 2000, 3, 2, 500 }
                    }
                };
            }
        }
    }
}
