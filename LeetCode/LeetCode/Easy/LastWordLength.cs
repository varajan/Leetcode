using System.Linq;

namespace LeetCode.Easy
{
    class LastWordLength
    {
        public int LengthOfLastWord(string s) => s.Trim().Split(' ').Last().Length;
    }
}