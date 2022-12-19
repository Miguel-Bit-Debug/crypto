import random

alphabet = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z', ' ', '.']
def gerar_chave(n):
    global alphabet
    shifts = []
    for i in range(n):
        shifts.append(random.randint(0, len(alphabet)))
    #return [random.randint(0, len(alphabet)) for i in range(n)]
    return shifts

def shift(char, shift):
    global alphabet
    nova_posicao = (alphabet.index(char) + shift) % len(alphabet)
    return alphabet[nova_posicao]
 

def criptografar(mensagem, shifts):
    global alphabet
    length = len(mensagem)
    return str.join('', [shift(mensagem[i], shifts[i]) for i in range(length)])

def descriptografar(mensagem, shifts):
    global alphabet
    length = len(mensagem)
    return str.join('', [shift(mensagem[i], shifts[i] * -1) for i in range(length)])

message = "desenvolvedor.io"
chave = gerar_chave(len(message))
print(chave)
print(shift('a', 98465))
cipher = criptografar(message, chave)
print('cipher:', cipher)
plainText = descriptografar(cipher, chave)
print('plainText:', plainText)
