using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Medium
{
    public class FindDuplicateFiles
    {
        public List<List<string>> FindDuplicate(string[] paths)
        {
            var contents = Content(paths);
            var result = new List<string>[contents.Count];
            for (int i = 0; i < contents.Count; i++)
            {
                result[i] = new List<string>();
            }

            foreach (var path in paths)
            {
                var files = GetPaths(path);
                foreach (var file in files)
                {
                    var index = contents.IndexOf(Content(file));
                    result[index].Add(GetPath(file));
                }
            }

            return result.ToList();
        }

        private string GetPath(string file) => file.Split('(').First();

        private List<string> GetPaths(string path)
        {
            var parts = path.Split(' ');
            var root = parts.First();
            var result = new List<string>();
            
            for (int i = 1; i < parts.Length; i++)
            {
                result.Add($"{root}/{parts[i]}");
            }

            return result;
        }

        private string Content(string file) => Regex.Matches(file, @"\(\w*\)").First().Value;

        private List<string> Content(string[] paths)
        {
            var result = new List<string>();

            foreach (var path in paths)
            {
                foreach (var match in Regex.Matches(path, @"\(\w*\)"))
                {
                    result.Add(match.ToString());
                }
            }

            return result.Distinct().ToList();
        }
    }
}