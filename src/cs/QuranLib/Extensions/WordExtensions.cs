using System.Text.RegularExpressions;

namespace QuranLib.Extensions;

public static partial class WordExtensions
{
    /// <summary>
    /// Remove tashkil from the Arabic text.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string RemoveTashkil(this string input) => TashkilRegex().Replace(input, "");

    public static string RemoveTashkilWithMapping(this string input, Dictionary<int, int> charMap)
    {
        StringBuilder normalized = new();
        var originalIndex = 0;

        for (var normIndex = 0; originalIndex < input.Length; originalIndex++)
        {
            var c = input[originalIndex];

            // Check if char is NOT Tashkeel
            if (TashkilRegex().IsMatch(c.ToString()))
                continue;

            // Map normalized index to original index
            charMap[normIndex] = originalIndex;
            normalized.Append(c);
            normIndex++;
        }

        return normalized.ToString();
    }

    [GeneratedRegex("[\u064B-\u065F]")]
    private static partial Regex TashkilRegex();
}