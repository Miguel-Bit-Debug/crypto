from Crypto.PublicKey import RSA
from Crypto.Cipher import PKCS1_OAEP
import binascii

parDeChave = RSA.generate(2048)
chavePublica = parDeChave.publickey()

msg = b'desenvolvedorio'

print("========================== CRIPTOGRAFAR =========================", "\n")
encryptor = PKCS1_OAEP.new(chavePublica)
encrypted = encryptor.encrypt(msg)
print("Cipher:", binascii.hexlify(encrypted))

print("========================== DESCRIPTOGRAFAR =========================", "\n")
decryptor = PKCS1_OAEP.new(parDeChave)
decrypted = decryptor.decrypt(encrypted)
print('Clear Text:', decrypted)
