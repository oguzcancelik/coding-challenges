using CodingChallenges.Algorithms.Abstractions;

namespace CodingChallenges.Algorithms;

public class StrongPasswordChecking : IAlgorithm<string, int>
{
    public int Run(string value)
    {
        return default;
    }

    public int StrongPasswordChecker(string password)
    {
        var (isValid, lowercaseChar, uppercaseChar, digitChar, repeatingChar, lengthCheck) = IsValid(password);

        if (isValid)
            return 0;

        var stepCount = 0;

        var passwordLength = password.Length;

        if (!lowercaseChar)
        {
            stepCount++;
            passwordLength++;
        }

        if (!uppercaseChar)
        {
            stepCount++;
            passwordLength++;
        }


        return default;
    }

    private static (bool isValid, bool lowercaseChar, bool uppercaseChar, bool digitChar, bool repeatingChar, bool lengthCheck) IsValid(string password)
    {
        var lowercaseChar = false;
        var uppercaseChar = false;
        var digitChar = false;
        var repeatingChar = true;
        var lengthCheck = password.Length is > 5 and < 21;

        for (var i = 0; i < password.Length; i++)
        {
            if (char.IsLower(password[i]))
                lowercaseChar = true;
            else if (char.IsUpper(password[i]))
                uppercaseChar = true;
            else if (char.IsDigit(password[i]))
                digitChar = true;

            if (i > 0 && i < password.Length - 1 && password[i - 1] == password[i] && password[i] == password[i + 1])
                repeatingChar = false;
        }

        var isValid = lowercaseChar && uppercaseChar && digitChar && repeatingChar && lengthCheck;

        return (isValid, lowercaseChar, uppercaseChar, digitChar, repeatingChar, lengthCheck);
    }
}