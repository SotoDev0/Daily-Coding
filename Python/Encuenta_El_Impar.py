"""
Dado un arreglo de números enteros, encuentra el que aparece un número impar de veces.

Siempre habrá un único número entero que aparecerá un número impar de veces.

Ejemplos
[7]debería devolver 7, porque ocurre 1 vez (lo cual es extraño).
[0]debería devolver 0, porque ocurre 1 vez (lo cual es extraño).
[1,1,2]debería devolver 2, porque ocurre 1 vez (lo cual es extraño).
[0,1,0,1,0]debería devolver 0, porque ocurre 3 veces (lo cual es extraño).
[1,2,2,3,3,3,4,3,3,3,2,2,1]debería devolver 4, porque aparece 1 vez (lo cual es extraño).
"""

def find_it(seq):
    dict = {}
    for i in seq:
        if i in dict:
            dict[i] += 1
        else:
            dict[i] = 1
    
    for key, value in dict.items():
        if value % 2 != 0:
            return key
        
print(find_it([10, 10, 10]))
print(find_it([1,1,1,1,1,1,10,1,1,1,1]))
print(find_it([5,4,3,2,1,5,4,3,2,10,10]))
print(find_it([20,1,1,2,2,3,3,5,5,4,20,4,5]))
print(find_it([1,1,2,-2,5,2,4,4,-1,-2,5]))