using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class FindDuplicateFiles
    {
        public List<List<string>> FindDuplicate(string[] paths)
        {
            var result = new Dictionary<string, List<string>>();

            foreach (var path in paths)
            {
                foreach (var file in GetPaths(path))
                {
                    var parts = file.Split('(');
                    var filePath = parts[0];
                    var content = parts[1];

                    if (result.ContainsKey(content))
                    {
                        result[content].Add(filePath);
                    }
                    else
                    {
                        result[content] = new List<string> { filePath };
                    }
                }
            }

            return result.Select(x => x.Value).Where(x => x.Count > 1).ToList();
        }

        private IEnumerable<string> GetPaths(string path)
        {
            var parts = path.Split(' ');
            var root = parts[0];
            var result = new List<string>();
            
            for (int i = 1; i < parts.Length; i++)
            {
                yield return root + "/" + parts[i];
            }
        }
    }
}