using System.Text.RegularExpressions;

namespace LeetCode.Medium
{
    public class SimplifyUnixPath
    {
        public string SimplifyPath(string path)
        {
            const string regex1 = @"/\.?/";
            const string regex2 = @"/\.?\w*/\.\./";
            const string regex3 = @"/\.?\w*/\.\.$";
            const string regex4 = @"/\.\./";
            const string regex5 = @"/\.?\.?$";
            const string regex6 = @"/$";

            while (Regex.IsMatch(path, regex1)) path = Regex.Replace(path, regex1, "/");
            while (Regex.IsMatch(path, regex2)) path = Regex.Replace(path, regex2, "/");
            while (Regex.IsMatch(path, regex3)) path = Regex.Replace(path, regex3, "");
            while (Regex.IsMatch(path, regex4)) path = Regex.Replace(path, regex4, "/");
            while (Regex.IsMatch(path, regex5)) path = Regex.Replace(path, regex5, "");
            while (Regex.IsMatch(path, regex6)) path = Regex.Replace(path, regex6, "");

            return path == string.Empty ? "/" : path;
        }
    }
}