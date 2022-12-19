import hashlib
from blake3 import blake3

mensagens = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']

for mensagem in mensagens:
    print('SHA-256:', mensagem, ' - ', hashlib.sha256(mensagem.encode('utf-8')).hexdigest())


for mensagem in mensagens:
    print('SHA-512:', mensagem, ' - ', hashlib.sha512(mensagem.encode('utf-8')).hexdigest())


for mensagem in mensagens:
    print('Blake3:', mensagem, ' - ', blake3(mensagem.encode('utf-8')).hexdigest())