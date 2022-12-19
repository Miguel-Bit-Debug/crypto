from fundamentos_criptografia_hashing import *
from tabulate import tabulate

print('============== CRIPTOGRAFANDO ==============\n')

secretKey = os.urandom(32)  # 256-bit random encryption key
mensagem=b'desenvolvedor.io'
dadosCriptografados = encrypt_AES_GCM(mensagem, secretKey)

dados = {
    'mensagem': mensagem,
    'senha': binascii.hexlify(secretKey),
    
    'Cipher': binascii.hexlify(dadosCriptografados[0]),
    'Initialization Vector (IV)': binascii.hexlify(dadosCriptografados[1]),
    'Auth Tag': binascii.hexlify(dadosCriptografados[2])
}

print(tabulate(dados.items(), tablefmt='fancy_grid'))


print('\n\n============== DESCRIPTOGRAFANDO ==============\n')

decryptedMsg = decrypt_AES_GCM(dadosCriptografados, secretKey)
print("Mensagem descriptografada", decryptedMsg.decode())


print('\n\n============== HASHING ==============\n')

digest=hashlib.sha256(mensagem).hexdigest()
print(f'Hash da mensagem \n{mensagem}={digest}')
