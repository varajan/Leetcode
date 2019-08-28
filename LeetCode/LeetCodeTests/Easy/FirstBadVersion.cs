using LeetCode.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LeetCodeTests.Easy
{
    [TestClass]
    public class FirstBadVersion
    {
        private void Test(int n, int version)
        {
            var moq = new Mock<IVersionControl>();
            moq.Setup(x => x.IsBadVersion(It.IsAny<int>())).Returns<int>(x => x >= version);
            var versionControl = new LeetCode.Easy.FirstBadVersion(moq.Object);

            Assert.AreEqual(version, versionControl.GetFirstBadVersion(n));
        }

        [TestMethod]
        public void FirstBadVersion_01() => Test(2, 1);

        [TestMethod]
        public void FirstBadVersion_02() => Test(5, 4);

        [TestMethod]
        public void FirstBadVersion_03() => Test(3, 3);

        [TestMethod]
        public void FirstBadVersion_04() => Test(2126753390, 1702766719);
    }
}