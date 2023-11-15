using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAndSearch.Search
{
    internal interface ISearch
    {
        int Search(ref int[] array, ref int searchedElement);
    }
}
