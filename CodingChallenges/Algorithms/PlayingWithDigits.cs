using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

public class PlayingWithDigits : IAlgorithm<(int n, int p), int>
{
    public int Run((int n, int p) value)
    {
        var (n, p) = value;

        var numbers = n.ToString().Select(x => int.Parse(x.ToString())).ToList();

        var sum = numbers.Sum(number => Math.Pow(number, p++));

        var division = sum / n;

        return division % 1 == 0 ? (int)division : -1;
    }
}