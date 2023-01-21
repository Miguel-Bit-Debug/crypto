
message = b"morte ao miojo";

messageBytes = [ 109, 111, 114, 116, 101, 32, 97, 111, 32, 109, 105, 111, 106, 111 ]
cipher = [ 37, 304, 45, 24, 16, 315, 79, 304, 315, 37, 265, 304, 30, 304 ]


p = 17
q = 23
n = p * q
totiente = (p -1) * (q - 1)
e = 3
d = 235

print("Message bytes")
print(messageBytes, end=" ")

print()

print("Cipher")
print(cipher, end=" ")

print()

lista = []
print("Message decifrada")
for num in cipher:
    print((num ** d) % n, end=" ")

    lista.append((num ** d) % n)


print()
print(lista == messageBytes)
