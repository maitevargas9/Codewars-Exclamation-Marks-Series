'''
Description

Move all exclamation marks to the end of the sentence

Examples
"Hi!"          ---> "Hi!"
"Hi! Hi!"      ---> "Hi Hi!!"
"Hi! Hi! Hi!"  ---> "Hi Hi Hi!!!"
"Hi! !Hi Hi!"  ---> "Hi Hi Hi!!!"
"Hi! Hi!! Hi!" ---> "Hi Hi Hi!!!!"
'''

def remove(string : str) -> str:
    return string.replace("!", "") + ''.join([char for char in string if char == '!'])