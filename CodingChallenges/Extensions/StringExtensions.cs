using Newtonsoft.Json;

namespace CodingChallenges.Extensions;

public static class StringExtensions
{
    public static string ToJson(this object source)
    {
        return JsonConvert.SerializeObject(source);
    }
}