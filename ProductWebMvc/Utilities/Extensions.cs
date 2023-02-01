using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ProductWebMvc.Utilities
{
    public static class Extensions
    {
        public static string ToUrl(this string text)
        {
            string result = text.ToLower().Trim();
            result = result.Replace("ş", "s")
                           .Replace("ç", "c")
                           .Replace("ı", "i")
                           .Replace("ğ", "g")
                           .Replace("ö", "o")
                           .Replace("ü", "u");

            result = Regex.Replace(result, @"[^\w\s]", "");
            result = Regex.Replace(result, @"\s+", " ").Trim();
            return result.Replace(" ", "-");
        }
    }
}
