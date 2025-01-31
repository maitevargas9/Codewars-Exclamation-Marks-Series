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

import java.util.Arrays;
import java.util.stream.Collectors;

public class R {

  public static String removeBang(String str) {
    return Arrays
      .stream(str.split(" "))
      .map(word -> word.replaceAll("!+$", ""))
      .collect(Collectors.joining(" "));
  }
}
