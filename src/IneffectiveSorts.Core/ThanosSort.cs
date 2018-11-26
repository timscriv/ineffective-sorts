using System;
using System.Collections.Generic;
using System.Linq;

namespace IneffectiveSorts.Core
{
    /// <summary>
    /// Thanossort: delete half the array. The arrays may or not be sorted, but it'll help for future sorting
    /// https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/e8ngs99
    /// </summary>
    public class ThanosSort : IIneffectiveSortingAlgorithm
    {
        private readonly Random _random = new Random();

        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            if (source?.Any() != true) return new int[0];

            return source.Where(_=> !ShouldBeSnapped()).ToArray();
        }

        private bool ShouldBeSnapped()
        {
            return _random.NextDouble() >= 0.5;
        }
    }
}
