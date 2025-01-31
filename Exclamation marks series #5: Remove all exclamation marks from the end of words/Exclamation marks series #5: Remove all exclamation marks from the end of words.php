<?php 
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

function remove(string $s): string {
  return implode(' ', array_map(function($word) {
    return preg_replace('/!+$/i', '', $word);
  }, explode(' ', $s)));
}
?>