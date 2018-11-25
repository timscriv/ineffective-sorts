using System;
using System.Collections.Generic;
using System.Linq;

namespace IneffectiveSorts.Core
{
    /// <summary>
    /// StalinSort: You iterate down the list of elements checking if they're in order. 
    /// Any element which is our of order is eliminated. 
    /// At the end you have a sorted list.
    /// https://www.reddit.com/r/ProgrammerHumor/comments/9s9kgn/nononsense_sorting_algorithm/
    /// </summary>
    public class StalinSort : IIneffectiveSortingAlgorithm
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            if (source?.Any() != true) return new int[0];
            int[] buffer = source.ToArray();
            List<int> output = new List<int>(buffer.Length)
            {
                buffer[0]
            };

            var prev = 0;
            for (int i = 1; i < buffer.Length; i++)
            {
                if (buffer[i] > buffer[prev])
                {
                    output.Add(buffer[i]);
                    prev = i;
                }
            }

            return output;
        }
    }
}
