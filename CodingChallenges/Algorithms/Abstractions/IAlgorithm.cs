namespace CodingChallenges.Algorithms.Abstractions;

public interface IAlgorithm<in T1, out T2>
{
    T2 Run(T1 value);
}