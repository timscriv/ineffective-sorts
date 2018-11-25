using System;
using System.Collections.Generic;
using System.Text;

namespace IneffectiveSorts.Core
{
    public interface IIneffectiveSortingAlgorithm
    {
        IEnumerable<int> Sort(IEnumerable<int> source);
    }
}
