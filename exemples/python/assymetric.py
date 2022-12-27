from colorama import Fore, Back, Style
from Crypto.PublicKey import RSA
from Crypto.Cipher import PKCS1_OAEP
import binascii

chaves = RSA.generate(2048)

chavePublica = chaves.publickey()


print("========================== PARAMETROS DO RSA =========================", "\n")
print(Fore.MAGENTA, "                            CHAVE PUBLICA (e,n):", Style.RESET_ALL)
print(Fore.YELLOW + "e =", Fore.GREEN + f"{chavePublica.e}", Style.RESET_ALL)
print(Fore.YELLOW + "n =", Fore.BLUE + f"{chavePublica.n}", Style.RESET_ALL, "\n")

pemChavePublica = chavePublica.exportKey()
print(pemChavePublica.decode('ascii'), "\n")

print(Fore.MAGENTA, "                            CHAVE PRIVADA (d,n):", Style.RESET_ALL)
print(Fore.YELLOW + "d =", Fore.RED + f"{chaves.d}", Style.RESET_ALL)
print(Fore.YELLOW + "n =", Fore.BLUE + f"{chavePublica.n}", Style.RESET_ALL, "\n")
pemChavePrivada = chaves.exportKey()
print(pemChavePrivada.decode('ascii'), "\n")


print("========================== VALIDANDO OS PARAMETROS ==========================", "\n")
print("Primo 1 (p) =", Fore.CYAN, chaves.p, Style.RESET_ALL, "\n")
print("Primo 2 (q) =", Fore.CYAN, chaves.q, Style.RESET_ALL, "\n")
print("Modulo  (n) =", Fore.BLUE, chaves.n, Style.RESET_ALL, "\n")
print("p * q = n ?", chaves.p * chaves.q == chaves.n, "\n")
print("========================== CRIPTOGRAFAR ==========================")
msg = b'desenvolvedorio'
encryptor = PKCS1_OAEP.new(chavePublica)
encrypted = encryptor.encrypt(msg)
print("Mensagem:", Fore.LIGHTYELLOW_EX, msg, Style.RESET_ALL)
print("Cypher:", Fore.MAGENTA, binascii.hexlify(encrypted), Style.RESET_ALL)

print("\n========================== DESCRIPTOGRAFAR ==========================")
decryptor = PKCS1_OAEP.new(chaves)
decrypted = decryptor.decrypt(encrypted)
print('Clear Text:', Fore.LIGHTYELLOW_EX, decrypted, Style.RESET_ALL)
