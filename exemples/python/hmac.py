import hashlib, hmac
from os import urandom
from tabulate import tabulate
from base64 import urlsafe_b64encode

key = urandom(16)
mensagem = b'Por favor, transfira $100 para o Miguel'

hmacDaMensagem = hmac.new(key, mensagem, hashlib.sha256).hexdigest()


dados = {
    'mensagem': mensagem.decode(),
    'senha': key.hex(),
    'hmac': hmacDaMensagem
}

print(tabulate(dados.items(), tablefmt='fancy_grid'))
