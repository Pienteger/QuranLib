using System.Text.RegularExpressions;

namespace QuranLib.Extensions;

public static class TextHighlighter
{
    public static string HighlightMatch(
        this string text,
        string searchTerm,
        Func<string, string> highlightWrapper
    )
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return text;

        // Dictionary to track index mapping between normalized and original text
        Dictionary<int, int> charMap = new();

        // Remove Tashkeel while tracking original indices
        var normalizedText = text.RemoveTashkilWithMapping(charMap);
        var normalizedSearchTerm = searchTerm.RemoveTashkil();

        // Find matches in the normalized text
        var matches = Regex.Matches(
            normalizedText,
            Regex.Escape(normalizedSearchTerm),
            RegexOptions.IgnoreCase
        );
        if (matches.Count == 0)
            return text; // No matches found

        // Reconstruct the text with highlights
        StringBuilder result = new();
        var lastIndex = 0;

        foreach (Match match in matches)
        {
            var normIndex = match.Index; // Index in normalized text

            if (!charMap.TryGetValue(normIndex, out var origIndex))
                continue; // Safety check

            var matchLength = match.Length;

            // Append everything before the match
            result.Append(text[lastIndex..origIndex]);

            // Extract the exact original match including Tashkeel
            var endIndex = charMap.ContainsKey(normIndex + matchLength - 1)
                ? charMap[normIndex + matchLength - 1] + 1
                : text.Length;
            var originalMatch = text[origIndex..endIndex];

            // Highlight the match using the provided wrapper function
            result.Append(highlightWrapper(originalMatch));

            lastIndex = endIndex;
        }

        // Append the remaining text
        result.Append(text[lastIndex..]);

        return result.ToString();
    }

    public static List<HighlightedSegment> GetHighlightedSegments(
        this string text,
        string searchTerm
    )
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return [new HighlightedSegment(text, false)];

        Dictionary<int, int> charMap = new();
        var normalizedText = text.RemoveTashkilWithMapping(charMap);
        var normalizedSearchTerm = searchTerm.RemoveTashkil();

        var matches = Regex.Matches(
            normalizedText,
            Regex.Escape(normalizedSearchTerm),
            RegexOptions.IgnoreCase
        );
        if (matches.Count == 0)
            return [new HighlightedSegment(text, false)];

        List<HighlightedSegment> segments = [];
        var lastIndex = 0;

        foreach (Match match in matches)
        {
            var normIndex = match.Index;
            if (!charMap.TryGetValue(normIndex, out var origIndex))
                continue;

            var matchLength = match.Length;
            var endIndex = charMap.ContainsKey(normIndex + matchLength - 1)
                ? charMap[normIndex + matchLength - 1] + 1
                : text.Length;

            // Add un-highlighted text before the match
            if (lastIndex < origIndex)
                segments.Add(new HighlightedSegment(text[lastIndex..origIndex], false));

            // Add the highlighted segment
            segments.Add(new HighlightedSegment(text[origIndex..endIndex], true));

            lastIndex = endIndex;
        }

        // Add remaining text
        if (lastIndex < text.Length)
            segments.Add(new HighlightedSegment(text[lastIndex..], false));

        return segments;
    }
}
