from Crypto.PublicKey import RSA
from Crypto.Signature.pkcs1_15 import PKCS115_SigScheme
from Crypto.Hash import SHA256

import binascii

parDeChaves = RSA.generate(2048)
chavePublica = parDeChaves.publickey()
mensagem = b'desenvolvedorio'

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
