using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/longest-valid-parentheses/
 */
public class LongestValidParentheses : IAlgorithm<string, int>
{
    public int Run(string value)
    {
        return LongestValidParenthesesMethod(value);
    }

    public int LongestValidParenthesesMethod(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var left = 0;
            var right = 0;

            for (var j = i; j < s.Length; j++)
            {
                if (s[j] == '(')
                    left++;
                else if (s[j] == ')' && left != 0)
                    right++;
                else
                    break;

                if (left == right && result < left + right)
                    result = left + right;

                if (left < right)
                    break;
            }

            if (result > s.Length - i)
                break;
        }

        return result;
    }
}