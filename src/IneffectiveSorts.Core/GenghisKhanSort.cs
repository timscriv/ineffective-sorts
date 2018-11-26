using System;
using System.Collections.Generic;
using System.Linq;

namespace IneffectiveSorts.Core
{
    /// <summary>
    /// GenghisKhanSort: delete all elements except for the first, repopulate the list with successors of the first element.
    /// https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/e8n8sdh
    /// </summary>
    public class GenghisKhanSort : IIneffectiveSortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            if (source?.Any() != true) return new int[0];

            int[] buffer = source.Select((c, i) => i == 0 ? c : -1).ToArray();

            return buffer.Select((c, i) => i == 0 ? c : buffer[0] + i);
            
            // TODO: And download a few viruses to weaken the computer before you conquer it. (https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/e8np1rq)
        }
    }
}
