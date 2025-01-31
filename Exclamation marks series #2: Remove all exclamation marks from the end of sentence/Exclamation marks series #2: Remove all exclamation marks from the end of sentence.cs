/*
Description

Remove all exclamation marks from the end of sentence.

Examples
"Hi!"     ---> "Hi"
"Hi!!!"   ---> "Hi"
"!Hi"     ---> "!Hi"
"!Hi!"    ---> "!Hi"
"Hi! Hi!" ---> "Hi! Hi"
"Hi"      ---> "Hi"
*/

using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static string Remove(string s)
    {
        return new Regex("!+$").Replace(s, "");
    }
}