using System.Collections.Generic;
using System.Linq;
using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class FindDuplicateFiles
    {
        private LeetCode.Medium.FindDuplicateFiles Find => new LeetCode.Medium.FindDuplicateFiles();

        [TestMethod]
        public void FindDuplicateFiles_01()
        {
            var input = new[] {"root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)"};
            var output = new List<List<string>>{
                new List<string>{"root/a/1.txt", "root/c/3.txt"},
                new List<string>{"root/a/2.txt", "root/c/d/4.txt", "root/4.txt"},
            };

            ListExtensions<string>.ShouldContainAll(Find.FindDuplicate(input), output);
        }
    }
}