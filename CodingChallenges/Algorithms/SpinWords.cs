using System.Text;
using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://www.codewars.com/kata/5264d2b162488dc400000001
 */

public class SpinWords : IAlgorithm<string, string>
{
    public string Run(string value)
    {
        var words = value.Split();

        var result = new StringBuilder();

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];

            var wordValue = word.Length > 4 ? ReverseString(word) : word;

            var space = i > 0 ? " " : string.Empty;

            result.Append($"{space}{wordValue}");
        }

        return result.ToString();
    }

    private static string ReverseString(string source)
    {
        var result = new StringBuilder();

        for (var i = source.Length - 1; i >= 0; i--)
            result.Append(source[i]);

        return result.ToString();
    }
}