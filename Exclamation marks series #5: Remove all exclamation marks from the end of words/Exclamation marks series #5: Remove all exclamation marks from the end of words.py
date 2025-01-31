'''
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
'''

import re

def remove(st):
    return ' '.join([re.sub(r'!+$', '', word) for word in st.split()])