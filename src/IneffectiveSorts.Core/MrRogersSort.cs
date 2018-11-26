using System;
using System.Collections.Generic;
using System.Linq;

namespace IneffectiveSorts.Core
{
    /// <summary>
    /// The Mr. Rogers sort. “This list is perfect just the way it is.”
    /// https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/e8nkosy
    /// </summary>
    public class MrRogersSort : IIneffectiveSortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            if (source?.Any() != true) return new int[0];

            return source.ToArray();
        }
    }
}
