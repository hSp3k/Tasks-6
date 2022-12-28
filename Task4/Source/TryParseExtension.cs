using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4.Source
{
    public static class TryParseExtension
    {
        public static bool UInt32TryPrase(this string? line)
        {
            if(string.IsNullOrWhiteSpace(line))
            {
                return false;
            }
            return Regex.IsMatch(line, @"^(?:[1-9]?)(?:\d+)$", RegexOptions.Compiled);
        }
    }
}
