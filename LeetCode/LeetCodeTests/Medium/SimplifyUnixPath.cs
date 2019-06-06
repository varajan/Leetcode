using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class SimplifyUnixPath
    {
        private LeetCode.Medium.SimplifyUnixPath Path => new LeetCode.Medium.SimplifyUnixPath();

        [TestMethod]
        public void SimplifyUnixPath_01() => Assert.AreEqual("/home", Path.SimplifyPath("/home/"));

        [TestMethod]
        public void SimplifyUnixPath_02() => Assert.AreEqual("/", Path.SimplifyPath("/./"));

        [TestMethod]
        public void SimplifyUnixPath_03() => Assert.AreEqual("/", Path.SimplifyPath("/../"));

        [TestMethod]
        public void SimplifyUnixPath_04() => Assert.AreEqual("/c", Path.SimplifyPath("/a/./b/../../c/"));

        [TestMethod]
        public void SimplifyUnixPath_05() => Assert.AreEqual("/home/foo", Path.SimplifyPath("/home//foo/"));

        [TestMethod]
        public void SimplifyUnixPath_06() => Assert.AreEqual("/a/b/c", Path.SimplifyPath("/a//b////c/d//././/.."));

        [TestMethod]
        public void SimplifyUnixPath_07() => Assert.AreEqual("/c", Path.SimplifyPath("/a/../../b/../c//.//"));

        [TestMethod]
        public void SimplifyUnixPath_08() => Assert.AreEqual("/", Path.SimplifyPath("/."));

        [TestMethod]
        public void SimplifyUnixPath_09() => Assert.AreEqual("/...", Path.SimplifyPath("/..."));

        [TestMethod]
        public void SimplifyUnixPath_10() => Assert.AreEqual("/abc/...", Path.SimplifyPath("/abc/..."));

        [TestMethod]
        public void SimplifyUnixPath_11() => Assert.AreEqual("/home/foo/.ssh2/authorized_keys", Path.SimplifyPath("/home/foo/.ssh/../.ssh2/authorized_keys/"));

        [TestMethod]
        public void SimplifyUnixPath_12() => Assert.AreEqual("/E", Path.SimplifyPath("/.././em/jl///../.././../E/"));

        [TestMethod]
        public void SimplifyUnixPath_13() => Assert.AreEqual("/lGwT/O/AEc/NhDwO/ceL/gge/nPFDz", Path.SimplifyPath("/lGwT///RAlm/./../O/AEc/NhDwO/ceL/u///../gge/nPFDz/./PEp/../OBqcV/./lw/../.."));
    }
}