using System.Globalization;
using System.Text;

namespace Kayki.StringUtils;
public class StringHelper
{
    private static readonly char[] separator = [' ', '\t', '\n'];

    public static string Reverse(string input)
    {
        ArgumentNullException.ThrowIfNull(input);

        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static int WordCount(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        string[] words = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public static string RemoveAccents(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string normalized = input.Normalize(NormalizationForm.FormD);
        char[] chars = normalized.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
        return new string(chars).Normalize(NormalizationForm.FormC);
    }

    public static string SafeSubstring(string input, int startIndex, int length)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        if (startIndex < 0)
            startIndex = 0;
        else if (startIndex >= input.Length)
            return string.Empty;

        if (length < 0)
            return string.Empty;
        if (startIndex + length > input.Length)
            length = input.Length - startIndex;

        return input.Substring(startIndex, length);
    }

    public static string Capitalize(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.ToLower());
    }
}
