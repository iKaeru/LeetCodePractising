using System;
using NUnit.Framework;
using LeetCode;

namespace LeetCodeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RotateImage_RotateEmpty_Success()
        {
            var inputMatrix = new[] {new int[0]};
        }

        [Test]
        public void RotateImage_Rotate1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};
            RotateImageSolution.Rotate(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_Rotate2x2_Success()
        {
            var inputMatrix = new[] {new[] {1, 2}, new[] {3, 4}};
            var resultMatrix = new[] {new[] {3, 1}, new[] {4, 2}};
            RotateImageSolution.Rotate(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_Rotate3x3_Success()
        {
            var inputMatrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var resultMatrix = new[] {new[] {7, 4, 1}, new[] {8, 5, 2}, new[] {9, 6, 3}};
            RotateImageSolution.Rotate(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_Rotate4x4_Success()
        {
            var inputMatrix = new[]
                {new[] {5, 1, 9, 11}, new[] {2, 4, 8, 10}, new[] {13, 3, 6, 7}, new[] {15, 14, 12, 16}};
            var resultMatrix = new[]
                {new[] {15, 13, 2, 5}, new[] {14, 3, 4, 1}, new[] {12, 6, 8, 9}, new[] {16, 7, 10, 11}};

            RotateImageSolution.Rotate(inputMatrix);

            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_Rotate5x5_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3}, new[] {2, 4, 8, 10, 8}, new[] {13, 3, 6, 7, 18},
                new[] {15, 14, 12, 16, 17}, new[] {10, 1, 7, 19, 13}
            };
            var resultMatrix = new[]
            {
                new[] {10, 15, 13, 2, 5}, new[] {1, 14, 3, 4, 1}, new[] {7, 12, 6, 8, 9},
                new[] {19, 16, 7, 10, 11}, new[] {13, 17, 18, 8, 3}
            };

            RotateImageSolution.Rotate(inputMatrix);

            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_Rotate6x6_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3, 5}, new[] {2, 4, 8, 10, 8, 9}, new[] {13, 3, 6, 7, 18, 8},
                new[] {15, 14, 12, 16, 17, 1}, new[] {10, 1, 7, 19, 13, 11}, new[] {11, 5, 3, 2, 15, 10}
            };
            var resultMatrix = new[]
            {
                new[] {11, 10, 15, 13, 2, 5}, new[] {5, 1, 14, 3, 4, 1}, new[] {3, 7, 12, 6, 8, 9},
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new [] {10, 11, 1, 8, 9, 5}
            };

            RotateImageSolution.Rotate(inputMatrix);

            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateImage_RotateNotMatrix_Exception()
        {
            var inputMatrix = new[] {new[] {1}, new[] {1, 2}};

            Assert.AreEqual("Given matrix is not square",
                Assert.Catch<ArgumentException>(() => RotateImageSolution.Rotate(inputMatrix)).Message);
        }

        [Test]
        public void RotateImage_RotateVertical_Exception()
        {
            var inputMatrix = new[] {new[] {1}, new[] {1}};

            Assert.AreEqual("Given matrix is not square",
                Assert.Catch<ArgumentException>(() => RotateImageSolution.Rotate(inputMatrix)).Message);
        }

        [Test]
        public void RotateImage_RotateHorizontal_Exception()
        {
            var inputMatrix = new[] {new[] {1}, new[] {1}};

            Assert.AreEqual("Given matrix is not square",
                Assert.Catch<ArgumentException>(() => RotateImageSolution.Rotate(inputMatrix)).Message);
        }
    }
}