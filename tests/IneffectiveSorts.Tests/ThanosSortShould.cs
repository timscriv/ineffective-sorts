using IneffectiveSorts.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace IneffectiveSorts.Tests
{
    public class ThanosSortShould
    {
        [Fact]
        public void ReturnEmptyIfNull()
        {
            var sorted = new ThanosSort().Sort(null);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void ReturnEmptyIfEmpty()
        {
            var sorted = new ThanosSort().Sort(new int[0]);

            Assert.Equal(new int[0], sorted);
        }

        [Fact]
        public void Sort()
        {
            var sorted = new ThanosSort().Sort(Enumerable.Range(1, 770000000));

            Assert.Equal(385000000, sorted.Count()); //runs for a full minute and is still not perfectly balanced. 
        }

        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {
                        
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
