using IneffectiveSorts.Core.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace IneffectiveSorts.Core
{
    /// <summary>
    /// ExistentialCrisisSort, where you realize that the array, like all things, are fleeting.
    /// Its only purpose is to keep us busy while we await the cold hand of death to take us all away. 
    /// You just leave the array alone and go have a beer before the array, computer and entire earth is swallowed up by the sun.
    /// https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/e8nge0p
    /// </summary>
    public class ExistentialCrisisSort : IIneffectiveSortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            if (source?.Any() != true) return new int[0];

            throw new ThisIsPointlessException("If one day I will be forgotten, what is the point of all of my work?");
        }
    }
}
