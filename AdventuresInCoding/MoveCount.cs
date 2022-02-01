using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Functionality
{

    /// <summary>
    /// Ignore this, another experiment in additional options
    /// </summary>
    public static class MoveCount
    {
        // arr1 is the numbers, arr2 is what we are looking for
        public static int MinimumMoves(List<int> arr1, List<int> arr2)
        {
            if (arr1.Count != arr2.Count)
            {
                return 0;
            }

            var totalNumberOfMoves = 0;

            for (int i = 0; i < arr1.Count; i++)
            {
                var startingPoint = arr1[i];
                var targetPoint = arr2[i];

                var rawStartingPoint = BreakDownIntegerValue(startingPoint);
                var rawTargetPoint = BreakDownIntegerValue(targetPoint);

                for (int rawIndex = 0; rawIndex < rawStartingPoint.Count; rawIndex++)
                {
                    totalNumberOfMoves += Math.Abs(rawStartingPoint[rawIndex] - rawTargetPoint[rawIndex]);
                }

            }

            return totalNumberOfMoves;

        }

        internal static List<int> BreakDownIntegerValue(int value)
        {
            if (value == 0) return new List<int>();
            var singleNumberList = BreakDownIntegerValue(value / 10);

            singleNumberList.Add(value % 10);

            return singleNumberList;
        }

    }
}
