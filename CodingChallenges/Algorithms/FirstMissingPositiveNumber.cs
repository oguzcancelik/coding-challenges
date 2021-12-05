using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/first-missing-positive/
 */
public class FirstMissingPositiveNumber : IAlgorithm<int[], int>
{
    public int Run(int[] value)
    {
        return FirstMissingPositive(value);
    }

    public int FirstMissingPositive(int[] nums)
    {
        var values = new HashSet<int>();

        foreach (var num in nums)
        {
            values.Add(num);
        }

        var max = 0;

        for (var i = 1; i <= nums.Length; i++)
        {
            if (values.Contains(i))
            {
                if (i > max)
                {
                    max = i;
                }
            }
            else
            {
                return i;
            }
        }

        return max + 1;
    }
}