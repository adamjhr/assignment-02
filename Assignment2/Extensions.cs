namespace Assignment2;

using System.Text.RegularExpressions;

public static class Extensions
{
    public static bool isSecure(this Uri url) {
        return url.Scheme == "https";
    }

    // Virker ikke
    public static int wordCount(this string words) {
        return Regex.Split(words, @"\p{L}+").Length - 1;
    }

}
