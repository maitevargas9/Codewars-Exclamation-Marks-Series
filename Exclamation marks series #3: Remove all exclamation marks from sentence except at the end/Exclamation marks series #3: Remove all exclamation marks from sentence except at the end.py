'''
Description

Remove all exclamation marks from sentence except at the end.

Examples
"Hi!"     ---> "Hi!"
"Hi!!!"   ---> "Hi!!!"
"!Hi"     ---> "Hi"
"!Hi!"    ---> "Hi!"
"Hi! Hi!" ---> "Hi Hi!"
"Hi"      ---> "Hi"
'''

def remove(s):
    return s.replace('!', '') + '!' * (len(s) - len(s.rstrip('!')))