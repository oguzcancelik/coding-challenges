using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/median-of-two-sorted-arrays/
 */

public class MedianOfTwoSortedArrays : IAlgorithm<(int[] first, int[] second), double>
{
    public double Run((int[] first, int[] second) value)
    {
        return FindMedianSortedArrays(value.first, value.second);
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var firstLength = nums1.Length;
        var secondLength = nums2.Length;

        var totalCount = firstLength + secondLength;

        var firstIndex = 0;
        var secondIndex = 0;

        var previous = 0;
        var current = 0;

        var range = (totalCount - 1) / 2 + 1;

        for (var i = 0; i <= range; i++)
        {
            previous = current;

            if (firstIndex == firstLength && secondIndex == secondLength)
                break;

            if (firstIndex == firstLength)
            {
                current = nums2[secondIndex];
                secondIndex++;

                continue;
            }

            if (secondIndex == secondLength)
            {
                current = nums1[firstIndex];
                firstIndex++;

                continue;
            }

            if (nums1[firstIndex] >= nums2[secondIndex])
            {
                current = nums2[secondIndex];
                secondIndex++;
            }
            else
            {
                current = nums1[firstIndex];
                firstIndex++;
            }
        }

        var median = totalCount % 2 == 1
            ? previous
            : ((double)previous + current) / 2;

        return median;
    }
}