using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/reverse-integer/
 */
public class ReverseInteger : IAlgorithm<int, int>
{
    public int Run(int value)
    {
        return Reverse(value);
    }

    public int Reverse(int x)
    {
        var max = (int)Math.Pow(2, 31) - 1;
        var min = -max - 1;

        var maxLastDigit = max % 10;
        var minLastDigit = -(min % 10);

        var reverse = 0;
        var sign = x >= 0 ? 1 : -1;

        while (x != 0)
        {
            var division = Math.Abs(x % 10);
            x /= 10;

            if (reverse > max / 10
                || reverse < min / 10
                || reverse == max / 10 && division > maxLastDigit
                || reverse == min / 10 && division > minLastDigit)
                return 0;

            reverse = reverse * 10 + division;
        }

        return sign * reverse;
    }
}