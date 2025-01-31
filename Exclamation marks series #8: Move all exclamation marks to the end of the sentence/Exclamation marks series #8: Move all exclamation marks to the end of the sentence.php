<?php 
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

function remove(string $s): string {
  return str_replace("!", "", $s, $w).str_repeat('!', $w);
}
?>