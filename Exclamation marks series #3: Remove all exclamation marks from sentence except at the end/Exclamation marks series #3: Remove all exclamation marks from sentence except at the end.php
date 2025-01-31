<?php 
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

function remove(string $s): string {
  $cleaned = str_replace('!', '', $s);
  preg_match('/!+$/', $s, $matches);
  return $cleaned . ($matches[0] ?? '');
}
?>