using CodingChallenges.Algorithms.Abstractions;
using CodingChallenges.Models;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/add-two-numbers/
 */

public class AddToNumbers : IAlgorithm<(ListNode first, ListNode second), ListNode>
{
    public ListNode Run((ListNode first, ListNode second) value)
    {
        return AddTwoNumbers(value.first, value.second);
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var values = new List<int>();
        var remainder = 0;

        do
        {
            var firstValue = l1?.val ?? 0;
            var secondValue = l2?.val ?? 0;

            var value = firstValue + secondValue + remainder;

            if (value >= 10)
            {
                remainder = 1;
                value -= 10;
            }
            else
            {
                remainder = 0;
            }

            values.Add(value);

            l1 = l1?.next;
            l2 = l2?.next;
        } while (l1 != null || l2 != null);

        if (remainder != 0)
        {
            values.Add(1);
        }

        ListNode total = null;

        for (var i = values.Count - 1; i >= 0; i--)
        {
            total = new ListNode(values[i], total);
        }

        return total;
    }
}