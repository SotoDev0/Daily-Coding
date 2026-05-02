# Completa la solución para que la función divida el formato camel case, utilizando un espacio entre palabras.

"""
Ejemplo:
"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
"""

def solution(s):
    string = ""
    for i in s:
        if i == i.upper():
            string += " "
        string += i
        
    return string
            
Test = solution("probandoLaFuncion")    
print(Test) 