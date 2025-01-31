/*
Description

Move all exclamation marks to the end of the sentence

Examples
"Hi!"          ---> "Hi!"
"Hi! Hi!"      ---> "Hi Hi!!"
"Hi! Hi! Hi!"  ---> "Hi Hi Hi!!!"
"Hi! !Hi Hi!"  ---> "Hi Hi Hi!!!"
"Hi! Hi!! Hi!" ---> "Hi Hi Hi!!!!"
*/

using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Remove(string s)
    {
        return s.Replace("!", "") + Regex.Replace(s, "[^!]", "");
    }
}