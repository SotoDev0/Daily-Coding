"""
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * * - Un Anagrama consiste en formar una palabra reordenando TODAS
 * las letras de otra palabra inicial. 
 * - Ambas palabras deben tener la misma longitud y la misma 
 * cantidad de cada carácter.
 * - NO hace falta comprobar que ambas palabras existan en el diccionario.
 * - Dos palabras exactamente iguales NO se consideran anagramas 
"""


def is_anagram(word1,word2):
    p1 = word1.lower().replace(" ","")
    p2 = word2.lower().replace(" ","")

    #No es anagrama si tienen distinta logitud
    if len(p1) != len(p2):
        return False
    
    return sorted(p1) == sorted(p2)


#Pruebas
print(is_anagram("roma","AMOR"))
print(is_anagram("Python","Typhon"))
print(is_anagram("Hola","Adios"))
