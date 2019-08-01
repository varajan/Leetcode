using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Medium
{
    [TestClass]
    public class ValidSudoku
    {
        private static LeetCode.Medium.ValidSudoku Sudoku => new LeetCode.Medium.ValidSudoku();

        [TestMethod]
        public void ValidSudoku_01()
        {
            var board = new[]
            {
                new[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            Assert.IsTrue(Sudoku.IsValidSudoku(board));
        }

        [TestMethod]
        public void ValidSudoku_02()
        {
            var board = new[] {
                new[] {'8','3','.','.','7','.','.','.','.'},
                new[] {'6','.','.','1','9','5','.','.','.'},
                new[] {'.','9','8','.','.','.','.','6','.'},
                new[] {'8','.','.','.','6','.','.','.','3'},
                new[] {'4','.','.','8','.','3','.','.','1'},
                new[] {'7','.','.','.','2','.','.','.','6'},
                new[] {'.','6','.','.','.','.','2','8','.'},
                new[] {'.','.','.','4','1','9','.','.','5'},
                new[] {'.','.','.','.','8','.','.','7','9'}
            };

            Assert.IsFalse(Sudoku.IsValidSudoku(board));
        }
    }
}