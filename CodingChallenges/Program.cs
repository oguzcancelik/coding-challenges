using CodingChallenges.Algorithms;
using CodingChallenges.Extensions;

var algorithm = new SpinWords();

var result = algorithm.Run("aaabbbb");

Console.WriteLine(result.ToJson());