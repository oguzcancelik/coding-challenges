using CodingChallenges.Algorithms.Abstractions;
using CodingChallenges.Models;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/reverse-nodes-in-k-group/
 */

public class ReverseNodesInKGroup : IAlgorithm<(ListNode head, int k), ListNode>
{
    public ListNode Run((ListNode head, int k) value)
    {
        return ReverseKGroup(value.head, value.k);
    }

    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var values = new List<int>();

        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        var division = values.Count / k;

        for (var i = 0; i < division; i += 1)
        {
            for (var j = 0; j < (k + 1) / 2; j++)
            {
                var leftIndex = i * k + j;
                var rigthIndex = i * k + k - j - 1;

                var left = values[leftIndex];
                var rigth = values[rigthIndex];

                values[leftIndex] = rigth;
                values[rigthIndex] = left;
            }
        }

        values.Reverse();

        var result = values.Aggregate<int, ListNode>(null, (current, value) => new ListNode { val = value, next = current });

        return result;
    }
}