using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/substring-with-concatenation-of-all-words/
 */

public class SubstringWithConcatenationOfAllWords : IAlgorithm<(string s, string[] words), IList<int>>
{
    public IList<int> Run((string s, string[] words) input)
    {
        return FindSubstring(input.s, input.words);
    }

    public IList<int> FindSubstring(string s, string[] words)
    {
        var totalLength = words.Length * words[0].Length;

        var indexes = new List<int>();

        for (var i = 0; i <= s.Length - totalLength; i++)
        {
            var current = s.Substring(i, totalLength);

            var addIndex = true;

            foreach (var word in words)
            {
                var wordIndex = FindIndex(current, word);

                if (wordIndex == -1)
                {
                    addIndex = false;
                    break;
                }

                current = $"{current[..wordIndex]}{current[(wordIndex + word.Length)..]}";
            }

            if (addIndex)
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }

    public static int FindIndex(string source, string word)
    {
        for (var i = 0; i < source.Length; i += word.Length)
        {
            if (source.Substring(i, word.Length) == word)
            {
                return i;
            }
        }

        return -1;
    }
}