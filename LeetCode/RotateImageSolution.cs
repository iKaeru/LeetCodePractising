using System;

namespace LeetCode
{
    // https://leetcode.com/problems/rotate-image/
    public static class RotateImageSolution
    {
        public static void Rotate(int[][] matrix)
        {
            var rowMaxAvailableIndex = GetRowMaxIndex(matrix.Length);
            if (rowMaxAvailableIndex == -1)
                return;
            for (var rowIndex = 0; rowIndex < rowMaxAvailableIndex; rowIndex++)
            {
                var borders = GetBordersDependingOnRow(rowIndex, matrix.Length);
                if (matrix[rowIndex].Length != matrix.Length)
                {
                    throw new ArgumentException("Given matrix is not square");
                }

                for (var columnIndex = borders.Item1; columnIndex < borders.Item2; columnIndex++)
                {
                    SwapElementsClockwise(matrix, borders, columnIndex);
                }
            }
        }

        /// <summary>
        /// Swap row elements with all coincident elements moving clockwise along square
        /// </summary>
        /// <param name="array">Reference to array that will be modified</param>
        /// <param name="borders">Define squares inside array</param>
        /// <param name="columnIndex">Current column index while moving in single row</param>
        private static void SwapElementsClockwise(int[][] array, (int, int) borders, int columnIndex)
        {
            var indexesOrder = new[]
                {borders.Item1, columnIndex, borders.Item2, borders.Item2 + borders.Item1 - columnIndex};
            var storedValues = new[] {0, 0};
            for (var i = 0; i < indexesOrder.Length; i++)
            {
                var currentIndex = indexesOrder[i];
                var nextIndex = indexesOrder[(i + 1) % indexesOrder.Length];
                var throughOneIndex = indexesOrder[(i + 2) % indexesOrder.Length];
                var storedValuesIndex = i % storedValues.Length;
                var storedValuesNextIndex = (i + 1) % storedValues.Length;
                storedValues[storedValuesNextIndex] = array[nextIndex][throughOneIndex];
                if (i == 0)
                {
                    array[nextIndex][throughOneIndex] = array[currentIndex][nextIndex];
                    continue;
                }

                array[nextIndex][throughOneIndex] = storedValues[storedValuesIndex];
            }
        }

        /// <summary>
        /// Calculates index of the middle row at array
        /// </summary>
        /// <param name="arrLength">Square array length</param>
        /// <returns><para>(-1) - if array is empty</para>
        /// <para>(half_of_rows) - if array length is even</para>
        /// <para>(half_of_rows rounding towards -∞) - if array length is odd</para></returns>
        private static int GetRowMaxIndex(int arrLength)
        {
            if (arrLength == 0)
                return -1;
            return arrLength / 2;
        }

        /// <summary>
        /// Calculates left and right column borders indexes
        /// </summary>
        /// <param name="rowIndex">Current array row index</param>
        /// <param name="arrLength">Square array length</param>
        /// <returns>(left_border, right_border)</returns>
        private static (int, int) GetBordersDependingOnRow(int rowIndex, int arrLength)
        {
            return (rowIndex, arrLength - 1 - rowIndex);
        }
    }
}