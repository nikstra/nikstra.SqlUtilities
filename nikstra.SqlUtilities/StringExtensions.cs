using System;
using System.Collections.Generic;
using System.Text;

namespace nikstra.SqlUtilities
{
    internal static class StringExtensions
    {
        public static string AddTSqlDelimiters(this string text) =>
            SurroundWith(text, "[", "]");

        public static string SurroundWith(this string text, string ends, bool force = false) =>
            SurroundWith(text, ends, ends, force);

        public static string SurroundWith(this string text, string prefix, string postfix, bool force = false)
        {
            if (text.StartsWith(prefix) && text.EndsWith(postfix) && !force)
            {
                return text;
            }

            return prefix + text + postfix;
        }
    }
}
