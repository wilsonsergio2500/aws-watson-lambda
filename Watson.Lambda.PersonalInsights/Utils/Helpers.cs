using System.Text.RegularExpressions;

namespace Watson.Lambda.PersonalInsights.Utils
{
    public static class Helpers
    {
        public static int getWordCount(string text) {
            var matches = Regex.Matches(text,
            @"[\w]+", RegexOptions.CultureInvariant | RegexOptions.Multiline
            | RegexOptions.IgnoreCase);

            return matches.Count;
        }

    }
}
