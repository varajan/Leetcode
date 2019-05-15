using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class CostomStringSorting
    {
        public string CustomSortString(string S, string T)
        {
            var chars = T.ToList();

            chars.Sort(new Comparer(S));

            return chars.Aggregate(string.Empty, (current, x) => current += x); ;
        }

        class Comparer : IComparer<char>
        {
            private string _sort;

            public Comparer(string sort)
            {
                _sort = sort;
            }

            int IComparer<char>.Compare(char x, char y)
            {
                var indexA = _sort.IndexOf(x);
                var indexB = _sort.IndexOf(y);

                if (indexA > 0 || indexB > 0)
                {
                    return indexA < indexB ? -1 : 1;
                }

                return x < y ? -1 : 1;
            }
        }
    }
}