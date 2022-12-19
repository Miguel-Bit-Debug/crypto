import hashlib
 
mensagem = "desenvolvedorio"
print("Mensagem:", mensagem)

print("\n============= SHA-3 =============")
print("SHA3-224 Value:", hashlib.sha3_224(mensagem.encode()).hexdigest())
print("SHA3-256 Value:", hashlib.sha3_256(mensagem.encode()).hexdigest())
print("SHA3-384 Value:", hashlib.sha3_384(mensagem.encode()).hexdigest())
print("SHA3-512 Value:", hashlib.sha3_512(mensagem.encode()).hexdigest())

print("\n============= SHA-2 =============")
print("SHA2-224 Value:", hashlib.sha224(mensagem.encode()).hexdigest())
print("SHA2-256 Value:", hashlib.sha256(mensagem.encode()).hexdigest())
print("SHA2-384 Value:", hashlib.sha384(mensagem.encode()).hexdigest())
print("SHA2-512 Value:", hashlib.sha512(mensagem.encode()).hexdigest())

print("\n============= SHA-1 =============")
print("SHA-1 Value:", hashlib.sha1(mensagem.encode()).hexdigest())