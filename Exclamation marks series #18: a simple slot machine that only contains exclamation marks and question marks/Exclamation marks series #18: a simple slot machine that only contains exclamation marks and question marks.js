/*
Description

You are playing a simple slot machine that only contains exclamation marks and question marks. 
Every time the slot machine is started, a string of 5 length is obtained. If you're lucky enough 
to get a Special permutation, you'll win the bonus. Give you a string s, return the highest bonus.

Bouns list:
Five-of-a-Kind:   ---- 1000
"!!!!!" or "?????"
Four-of-a-Kind:    ---- 800
The string contains a "!!!!" or "????"
"!!!!?","?!!!!","????!","!????"
Full House:         ----500
such as "!!!??" or "???!!"...
Three-of-a-Kind:    ---- 300
The string contains a "!!!" or "???"
such as "!!!?!","!???!"...
Two pair:           ---- 200
The string contains two "!!" or "??"
such as "??!!?","!!?!!"
A Pair:             ---- 100
The string contains a "!!" or "??"
such as "?!??!","!!?!?"
Others              ---- 0
such as "?!?!?","!?!?!"

Examples
slot("!!!!!") === 1000
slot("!!!!?") === 800
slot("!!!??") === 500
slot("!!!?!") === 300
slot("!!?!!") === 200
slot("!!?!?") === 100
slot("!?!?!") === 0
*/

function slot(s) {
  return s === "!!!!!" || s === "?????"
    ? 1000
    : s.includes("!!!!") || s.includes("????")
    ? 800
    : s === "!!!??" || s === "???!!" || s === "??!!!" || s === "!!???"
    ? 500
    : s.includes("!!!") || s.includes("???")
    ? 300
    : s === "!!?!!" ||
      s === "??!??" ||
      s === "!!??!" ||
      s === "??!!?" ||
      s === "!??!!" ||
      s === "?!!??"
    ? 200
    : s.includes("??") || s.includes("!!")
    ? 100
    : 0;
}
