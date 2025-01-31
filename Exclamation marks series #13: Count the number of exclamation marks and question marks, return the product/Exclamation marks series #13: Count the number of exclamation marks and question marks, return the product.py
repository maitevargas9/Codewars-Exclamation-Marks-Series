'''
Description

Count the number of exclamation marks and question marks, return the product.

Examples
""          --->   0
"!"         --->   0
"!ab? ?"    --->   2
"!!"        --->   0
"!??"       --->   2
"!???"      --->   3
"!!!??"     --->   6
"!!!???"    --->   9
"!???!!"    --->   9
"!????!!!?" --->  20
'''

import re

def product(st):
    count_questions = len(re.findall(r'\?', st))
    count_exclamations = len(re.findall(r'!', st))
    
    return count_questions * count_exclamations