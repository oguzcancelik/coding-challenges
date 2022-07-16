using CodingChallenges.Algorithms.Abstractions;
using CodingChallenges.Models;

namespace CodingChallenges.Algorithms;

/*
 * https://leetcode.com/problems/merge-k-sorted-lists/
 */

public class MergeKSortedLists : IAlgorithm<ListNode[], ListNode>
{
    public ListNode Run(ListNode[] value)
    {
        return MergeKLists(value);
    }

    public ListNode MergeKLists(ListNode[] lists)
    {
        var values = new List<int>();

        while (true)
        {
            var index = LowestIndex(lists);

            if (!index.HasValue)
                break;

            var current = lists[index.Value];

            values.Add(current.val);

            lists[index.Value] = lists[index.Value].next;
        }


        ListNode result = null;

        for (var i = values.Count - 1; i >= 0; i--)
            result = new ListNode(values[i], result);

        return result;
    }

    private int? LowestIndex(IReadOnlyList<ListNode> listNodes)
    {
        int? value = null;
        int? index = null;

        for (var i = 0; i < listNodes.Count; i++)
        {
            if (listNodes[i] != null && (!value.HasValue || value > listNodes[i].val))
            {
                value = listNodes[i].val;
                index = i;
            }
        }

        return index;
    }
}