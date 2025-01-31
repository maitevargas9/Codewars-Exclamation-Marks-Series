/*
Description

Task
Remove all exclamation marks from the end of words. Words are separated by a single space. 
There are no exclamation marks within a word.

Examples
remove("Hi!") === "Hi"
remove("Hi!!!") === "Hi"
remove("!Hi") === "!Hi"
remove("!Hi!") === "!Hi"
remove("Hi! Hi!") === "Hi Hi"
remove("!!!Hi !!hi!!! !hi") === "!!!Hi !!hi !hi"
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
    public static string Remove(string s)
    {
        return string.Join(" ", s.Split(' ').Select(word => Regex.Replace(word, "!+$", "")));
    }
}