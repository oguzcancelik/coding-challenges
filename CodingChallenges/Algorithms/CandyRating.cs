using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/candy/
 */

public class CandyRating : IAlgorithm<int[], int>
{
    public int Run(int[] value)
    {
        return Candy(value);
    }

    public int Candy(int[] ratings)
    {
        var result = new int[ratings.Length];
        result[0] = 1;
        var total = 1;

        for (var i = 1; i < ratings.Length; i++)
        {
            var current = ratings[i];
            var previous = ratings[i - 1];

            if (current > previous)
                result[i] = result[i - 1] + 1;
            else if (current < previous && result[i - 1] == 1)
            {
                for (var j = i - 1;; j--)
                {
                    result[j] += 1;
                    total++;

                    if (j == 0 || ratings[j] >= ratings[j - 1] || result[j - 1] >= result[j] + 1)
                        break;
                }

                result[i] = 1;
            }
            else
                result[i] = 1;

            total += result[i];
        }

        return total;
    }
}