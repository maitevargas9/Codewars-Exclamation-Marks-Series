'''
Description

Remove words from the sentence if they contain exactly one exclamation mark. Words are separated by a single space, 
without leading/trailing spaces.

Examples
remove("Hi!") === ""
remove("Hi! Hi!") === ""
remove("Hi! Hi! Hi!") === ""
remove("Hi Hi! Hi!") === "Hi"
remove("Hi! !Hi Hi!") === ""
remove("Hi! Hi!! Hi!") === "Hi!!"
remove("Hi! !Hi! Hi!") === "!Hi!"
'''

def remove(s):
    return ' '.join(w for w in s.split(' ') if w.count('!') != 1)