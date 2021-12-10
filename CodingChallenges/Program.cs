using CodingChallenges.Algorithms;
using CodingChallenges.Extensions;

var algorithm = new LongestValidParentheses();

var result = algorithm.Run(")()())()()(");

Console.WriteLine(result.ToJson());