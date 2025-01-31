/*
Description

Remove all exclamation marks from sentence except at the end.

Examples
"Hi!"     ---> "Hi!"
"Hi!!!"   ---> "Hi!!!"
"!Hi"     ---> "Hi"
"!Hi!"    ---> "Hi!"
"Hi! Hi!" ---> "Hi Hi!"
"Hi"      ---> "Hi"
*/

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static string Remove(string s)
    {
        return s.Replace("!", "") + Regex.Match(s, "!+$").Value;
    }
}