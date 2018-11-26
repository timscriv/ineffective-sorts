using IneffectiveSorts.Core;
using IneffectiveSorts.Core.Exceptions;
using System.Collections.Generic;
using Xunit;

namespace IneffectiveSorts.Tests
{
    public class ExistentialCrisisSortShould
    {
        [Fact]
        public void ReturnEmptyIfNull()
        {
            var sorted = new ExistentialCrisisSort().Sort(null);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void ReturnEmptyIfEmpty()
        {
            var sorted = new ExistentialCrisisSort().Sort(new int[0]);

            Assert.Equal(new int[0], sorted);
        }

        [Theory, MemberData(nameof(Data))]
        public void Sort(int[] given)
        {
            Assert.Throws<ThisIsPointlessException>(() => new ExistentialCrisisSort().Sort(given));
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new[] { 1, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 10, 2, 5, 4, 3 }
                    },
                    new object[] {
                        new[] { 1, 2, 3, 2, 5 }
                    },
                    new object[] {
                        new[] { 1, 2000, 3, 2, 500 }
                    }
                };
            }
        }
    }
}
