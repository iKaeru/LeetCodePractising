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
            var resultMatrix = new[] {new int[0]};

            RotateImageSolution.Rotate(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
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
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new[] {10, 11, 1, 8, 9, 5}
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

        // -------- Rotate solution with matrix operations --------

        [Test]
        public void RotateTransposeMainReflectVertically_1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            RotateImageWithMatrixOperation.TransposeMainReflectVertically(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateTransposeMainReflectVertically_5x5_Success()
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

            RotateImageWithMatrixOperation.TransposeMainReflectVertically(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateTransposeMainReflectVertically_6x6_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3, 5}, new[] {2, 4, 8, 10, 8, 9}, new[] {13, 3, 6, 7, 18, 8},
                new[] {15, 14, 12, 16, 17, 1}, new[] {10, 1, 7, 19, 13, 11}, new[] {11, 5, 3, 2, 15, 10}
            };
            var resultMatrix = new[]
            {
                new[] {11, 10, 15, 13, 2, 5}, new[] {5, 1, 14, 3, 4, 1}, new[] {3, 7, 12, 6, 8, 9},
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new[] {10, 11, 1, 8, 9, 5}
            };

            RotateImageWithMatrixOperation.TransposeMainReflectVertically(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectHorizontallyTransposeMain_1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            RotateImageWithMatrixOperation.ReflectHorizontallyTransposeMain(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectHorizontallyTransposeMain_5x5_Success()
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

            RotateImageWithMatrixOperation.ReflectHorizontallyTransposeMain(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectHorizontallyTransposeMain_6x6_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3, 5}, new[] {2, 4, 8, 10, 8, 9}, new[] {13, 3, 6, 7, 18, 8},
                new[] {15, 14, 12, 16, 17, 1}, new[] {10, 1, 7, 19, 13, 11}, new[] {11, 5, 3, 2, 15, 10}
            };
            var resultMatrix = new[]
            {
                new[] {11, 10, 15, 13, 2, 5}, new[] {5, 1, 14, 3, 4, 1}, new[] {3, 7, 12, 6, 8, 9},
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new[] {10, 11, 1, 8, 9, 5}
            };

            RotateImageWithMatrixOperation.ReflectHorizontallyTransposeMain(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateTransposeSideReflectHorizontally_1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            RotateImageWithMatrixOperation.TransposeSideReflectHorizontally(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateTransposeSideReflectHorizontally_5x5_Success()
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

            RotateImageWithMatrixOperation.TransposeSideReflectHorizontally(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateTransposeSideReflectHorizontally_6x6_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3, 5}, new[] {2, 4, 8, 10, 8, 9}, new[] {13, 3, 6, 7, 18, 8},
                new[] {15, 14, 12, 16, 17, 1}, new[] {10, 1, 7, 19, 13, 11}, new[] {11, 5, 3, 2, 15, 10}
            };
            var resultMatrix = new[]
            {
                new[] {11, 10, 15, 13, 2, 5}, new[] {5, 1, 14, 3, 4, 1}, new[] {3, 7, 12, 6, 8, 9},
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new[] {10, 11, 1, 8, 9, 5}
            };

            RotateImageWithMatrixOperation.TransposeSideReflectHorizontally(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectVerticallyTransposeSide_1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            RotateImageWithMatrixOperation.ReflectVerticallyTransposeSide(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectVerticallyTransposeSide_5x5_Success()
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

            RotateImageWithMatrixOperation.ReflectVerticallyTransposeSide(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void RotateReflectVerticallyTransposeSide_6x6_Success()
        {
            var inputMatrix = new[]
            {
                new[] {5, 1, 9, 11, 3, 5}, new[] {2, 4, 8, 10, 8, 9}, new[] {13, 3, 6, 7, 18, 8},
                new[] {15, 14, 12, 16, 17, 1}, new[] {10, 1, 7, 19, 13, 11}, new[] {11, 5, 3, 2, 15, 10}
            };
            var resultMatrix = new[]
            {
                new[] {11, 10, 15, 13, 2, 5}, new[] {5, 1, 14, 3, 4, 1}, new[] {3, 7, 12, 6, 8, 9},
                new[] {2, 19, 16, 7, 10, 11}, new[] {15, 13, 17, 18, 8, 3}, new[] {10, 11, 1, 8, 9, 5}
            };

            RotateImageWithMatrixOperation.ReflectVerticallyTransposeSide(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        // -------- Matrix operations --------

        [Test]
        public void TransposeOverMainDiagonal_Transpose1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            MatrixOperations.TransposeOverMainDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void TransposeOverMainDiagonal_Transpose2x2_Success()
        {
            var inputMatrix = new[] {new[] {1, 2}, new[] {3, 4}};
            var resultMatrix = new[] {new[] {1, 3}, new[] {2, 4}};

            MatrixOperations.TransposeOverMainDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void TransposeOverMainDiagonal_Transpose3x3_Success()
        {
            var inputMatrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var resultMatrix = new[] {new[] {1, 4, 7}, new[] {2, 5, 8}, new[] {3, 6, 9}};

            MatrixOperations.TransposeOverMainDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void TransposeOverSideDiagonal_Transpose1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            MatrixOperations.TransposeOverSideDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void TransposeOverSideDiagonal_Transpose2x2_Success()
        {
            var inputMatrix = new[] {new[] {1, 2}, new[] {3, 4}};
            var resultMatrix = new[] {new[] {4, 2}, new[] {3, 1}};

            MatrixOperations.TransposeOverSideDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void TransposeOverSideDiagonal_Transpose3x3_Success()
        {
            var inputMatrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var resultMatrix = new[] {new[] {9, 6, 3}, new[] {8, 5, 2}, new[] {7, 4, 1}};

            MatrixOperations.TransposeOverSideDiagonal(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectLeftToRight_Reflect1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            MatrixOperations.ReflectLeftToRight(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectLeftToRight_Reflect2x2_Success()
        {
            var inputMatrix = new[] {new[] {1, 2}, new[] {3, 4}};
            var resultMatrix = new[] {new[] {2, 1}, new[] {4, 3}};

            MatrixOperations.ReflectLeftToRight(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectLeftToRight_Reflect3x3_Success()
        {
            var inputMatrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var resultMatrix = new[] {new[] {3, 2, 1}, new[] {6, 5, 4}, new[] {9, 8, 7}};

            MatrixOperations.ReflectLeftToRight(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectTopToBottom_Reflect1x1_Success()
        {
            var inputMatrix = new[] {new[] {1}};
            var resultMatrix = new[] {new[] {1}};

            MatrixOperations.ReflectTopToBottom(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectTopToBottom_Reflect2x2_Success()
        {
            var inputMatrix = new[] {new[] {1, 2}, new[] {3, 4}};
            var resultMatrix = new[] {new[] {3, 4}, new[] {1, 2}};

            MatrixOperations.ReflectTopToBottom(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }

        [Test]
        public void ReflectTopToBottom_Reflect3x3_Success()
        {
            var inputMatrix = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var resultMatrix = new[] {new[] {7, 8, 9}, new[] {4, 5, 6}, new[] {1, 2, 3}};

            MatrixOperations.ReflectTopToBottom(inputMatrix);
            Assert.AreEqual(resultMatrix, inputMatrix);
        }
    }
}