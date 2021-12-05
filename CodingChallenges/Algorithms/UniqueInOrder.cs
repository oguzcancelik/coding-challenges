using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://www.codewars.com/kata/54e6533c92449cc251001667
 */

public class UniqueInOrder<T> : IAlgorithm<IEnumerable<T>, IEnumerable<T>>
{
    public IEnumerable<T> Run(IEnumerable<T> value)
    {
        var data = value.ToList();

        return data.Where((t, i) => i == 0 || !t.Equals(data[i - 1])).ToList();
    }
}