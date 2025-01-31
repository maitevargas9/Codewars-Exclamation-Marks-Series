/*
Description

Replace all vowel to exclamation mark in the sentence. aeiouAEIOU is vowel.

Examples
replace("Hi!") === "H!!"
replace("!Hi! Hi!") === "!H!! H!!"
replace("aeiou") === "!!!!!"
replace("ABCDE") === "!BCD!"
*/

using System;
using System.Linq;

public static class Kata
{
    public static string Replace(string s)
    {
        return string.Concat(s.Select(x => "aeiouAEIOU".Contains(x) ? '!' : x));
    }
}