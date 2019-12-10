using System.Linq;

namespace LeetCode.Easy
{
    public class PlusOneSolution
    {
            public int[] PlusOne(int[] digits)
            {
                var offset = 1;
                var result = digits.ToList();

                for (int i = result.Count - 1; i >= 0; i--)
                {
                    if (result[i]++ == 9)
                    {
                        result[i] = 0;
                    }
                    else
                    {
                        offset = 0;
                        break;
                    }
                }

                if (offset == 1) result.Insert(0, 1);

                return result.ToArray();
            }
        }
    }
}