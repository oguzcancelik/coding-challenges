using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * -- EASY --
 * https://leetcode.com/problems/two-sum/solution/
 */
public class TwoSumProblem : IAlgorithm<(int[] nums, int target), int[]>
{
    public int[] Run((int[] nums, int target) value)
    {
        return TwoSum(value.nums, value.target);
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var values = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];

            if (values.TryGetValue(complement, out var index))
                return new[] { i, index };

            values[nums[i]] = i;
        }

        return default;
    }
}