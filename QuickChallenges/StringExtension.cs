using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickChallenges
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/de-de/dotnet/csharp/programming-guide/classes-and-structs/extension-methods"/>
    internal static class StringExtension
    {
        internal static bool IsPalindrom(this string text, bool isCaseSensitive = false)
        {
            var result = new StringBuilder();
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = text.Length; i > 0; i--)
            {
                result.Append(text.Substring(i - 1, 1));
                Console.WriteLine(result);
            }
            Console.ForegroundColor = ConsoleColor.White;

            if (isCaseSensitive)
            {
                if (text.Equals(result.ToString(), StringComparison.Ordinal))
                {
                    return true;
                }
            }
            else
            {
                if (text.Equals(result.ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether the specified text is number.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is number; otherwise, <c>false</c>.
        /// </returns>
        /// <see cref="https://regex101.com/"/>
        internal static bool IsNumber(this string text)
        {
            #region hide
            //var chars = text.ToCharArray();

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    if (!int.TryParse(chars[i].ToString(), out _))
            //    {
            //        return false;
            //    }
            //}

            //return true;
            #endregion

            #region hide
            var pattern = @"^[\d]*$";
            return Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);
            #endregion
        }

        #region hide
        internal static int CountMatches(this string text, string pattern)
        {
            var result = Regex.Matches(text, pattern);
            return result.Count;
        }
        #endregion
    }
}
