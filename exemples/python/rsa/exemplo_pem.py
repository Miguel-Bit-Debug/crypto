from Crypto.PublicKey import RSA
from Crypto.Signature.pkcs1_15 import PKCS115_SigScheme
from Crypto.Cipher import PKCS1_OAEP
from Crypto.Hash import SHA256
import binascii

pem = open('./Modulo-05/Aula-14/rsa-private-key.pem','r')
parDeChaves = RSA.import_key(pem.read())
chavePublica = parDeChaves.publickey()

mensagem = b'desenvolvedorio'

print("========================== CRIPTOGRAFAR =========================", "\n")
encryptor = PKCS1_OAEP.new(chavePublica)
encrypted = encryptor.encrypt(mensagem)
print("Cipher:", binascii.hexlify(encrypted))


print("========================== DESCRIPTOGRAFAR =========================", "\n")
decryptor = PKCS1_OAEP.new(parDeChaves)
decrypted = decryptor.decrypt(encrypted)
print('Clear Text:', decrypted)


print("========================== ASSINAR DIGITALMENTE =========================", "\n")
hash = SHA256.new(mensagem)
assinante = PKCS115_SigScheme(parDeChaves)
assinatura = assinante.sign(hash)
print("Documento:", mensagem)
print("Assinatura:", binascii.hexlify(assinatura))


print("\n========================== VERIFICAR ASSINATURA =========================", "\n")
verifier = PKCS115_SigScheme(chavePublica)

try:
    verifier.verify(hash, assinatura)
    print("Assinatura valida.")
except:
    print("Assinatura invalida.")


print("========================== CARREGAR CHAVE PUBLICA =========================", "\n")
pem = open('./Modulo-05/Aula-14/rsa-public-key.pem','r')
parDeChaves = RSA.import_key(pem.read())
chavePublica = parDeChaves.publickey()

print("Utilizando objeto RSA apenas com chave publica")



print("\n========================== CRIPTOGRAFAR COM CHAVE PUBLICA =========================", "\n")

encryptor = PKCS1_OAEP.new(chavePublica)
encrypted = encryptor.encrypt(mensagem)
print("Cipher:", binascii.hexlify(encrypted))



print("\n========================== VALIDAR ASSINATURA COM CHAVE PUBLICA =========================", "\n")
verifier = PKCS115_SigScheme(chavePublica)

try:
    verifier.verify(hash, assinatura)
    print("Assinatura valida.")
except:
    print("Assinatura invalida.")



print("\n========================== TENTAR DESCRIPTOGRAFAR COM CHAVE PUBLICA =========================", "\n")
try:
    decryptor = PKCS1_OAEP.new(parDeChaves)
    decryptor.decrypt(encrypted)
except Exception as e:
    print("Erro:", e)



print("\n========================== TENTAR ASSINAR COM CHAVE PUBLICA =========================", "\n")
try:
    assinante = PKCS115_SigScheme(parDeChaves)
    assinatura = assinante.sign(hash)
except Exception as e:
    print("Erro:", e)
