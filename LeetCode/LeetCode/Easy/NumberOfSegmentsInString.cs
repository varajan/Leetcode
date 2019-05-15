namespace LeetCode.Easy
{
    class NumberOfSegmentsInString
    {
        public int CountSegments(string s)
        {
            if (s.Trim() == "") return 0;

            while (s.Contains("  ")) s = s.Replace("  ", " ");

            return s.Trim().Split(' ').Length;
        }
    }
}