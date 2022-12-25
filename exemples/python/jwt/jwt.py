import hashlib, hmac
from jws_example import *
from os import urandom
from base64 import urlsafe_b64encode

print('================= EXEMPLO JWT =================')
headerSegment = {
    "alg": "HS256",
    "typ": "JWT"
}
showHeader(headerSegment)

payloadRepresentation = {
    "claim1": 10 ,
    "claim2": "claim2-value",
    "name": "Bruno Brito",
    "given_name": "Bruno" ,
    "social": {
        "facebook": "brunohbrito",
        "google": "bhdebrito"
    },
    "logins": [ "brunohbrito", "bhdebrito", "bruno_hbrito" ]
}
showPayload(payloadRepresentation)

print('#######################      PASSO 1: Convertendo para bytes      #######################\n')
headerBytes = json.dumps(headerSegment, separators=(',', ':')).encode('utf-8')
payloadBytes = json.dumps(payloadRepresentation, separators=(',', ':')).encode('utf-8')
showBytes(headerBytes, payloadBytes)
# urlsafe_b64encode(header)

print('#######################      PASSO 2: Transforma em Base64Url      #######################\n');
header = urlsafe_b64encode(headerBytes).rstrip(b'=').decode('utf-8')
payload = urlsafe_b64encode(payloadBytes).rstrip(b'=').decode('utf-8')
showBase64Parts(header, payload)

print('#######################      PASSO 3: Gera a assinatura      #######################\n');
signatureSegment = f'{header}.{payload}'
showSignatureParts(header, payload)

print('#######################      PASSO 4: Assinando      #######################\n');

key = urandom(16)
#key = b'bruno'
assinatura = urlsafe_b64encode(hmac.digest(key, signatureSegment.encode('utf-8'), digest=hashlib.sha256))
assinatura = assinatura.rstrip(b'=').decode('utf-8')
showSignatureFinals(assinatura)


print('#######################      PASSO 5: Criando o JWS      #######################\n');

jws = f'{header}.{payload}.{assinatura}'
showJws(header, payload, assinatura)

print('#######################      Validando no jwt.io      #######################\n');
print(Fore.LIGHTYELLOW_EX + 'Senha base64Url: ' + Fore.GREEN + urlsafe_b64encode(key).decode('utf-8'), Style.RESET_ALL)