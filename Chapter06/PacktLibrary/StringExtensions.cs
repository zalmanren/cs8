using System;
using System.Text.RegularExpressions;
namespace Packt.Shared;

public static class StringExtensions
{
    private const string Pattern = @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+";

    public static bool IsValidEmail(this string input)
    {
        return Regex.IsMatch(input, Pattern);
    }
}