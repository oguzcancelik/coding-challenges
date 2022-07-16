using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/longest-palindromic-substring/
 */

public class LongestPalindromicSubstring : IAlgorithm<string, string>
{
    public string Run(string value)
    {
        return LongestPalindrome(value);
    }

    public string LongestPalindrome(string s)
    {
        for (var i = s.Length; i > 1; i--)
        {
            for (var j = 0; j <= s.Length - i; j++)
            {
                var value = s.Substring(j, i);

                if (IsPalindromic(value))
                    return value;
            }
        }

        return s[0].ToString();
    }

    private static bool IsPalindromic(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            var result = s[i] == s[s.Length - 1 - i];

            if (!result)
                return false;
        }

        return true;
    }
}