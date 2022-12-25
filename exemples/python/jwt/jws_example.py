from colorama import Fore, Back, Style
import json

def showHeader(header):
    print(Fore.LIGHTYELLOW_EX + 'header:', Style.RESET_ALL)
    print(Fore.GREEN + json.dumps(header, sort_keys=True, indent=4), Style.RESET_ALL)
    print()

def showPayload(payload):
    print(Fore.LIGHTYELLOW_EX + 'payload:', Style.RESET_ALL)
    print(Fore.GREEN + json.dumps(payload, sort_keys=True, indent=4), Style.RESET_ALL)
    print()

def showBytes(header, payload):
    print(Fore.LIGHTYELLOW_EX + 'header:', Style.RESET_ALL)
    print(Fore.GREEN, header, Style.RESET_ALL)
    print()
    print(Fore.LIGHTYELLOW_EX + 'payload:', Style.RESET_ALL)
    print(Fore.GREEN, payload, Style.RESET_ALL)
    print()

def showBase64Parts(header, payload):
    print(Fore.LIGHTYELLOW_EX + 'header:', Style.RESET_ALL)
    print(Fore.GREEN, header, Style.RESET_ALL)
    print()
    print(Fore.LIGHTYELLOW_EX + 'payload:', Style.RESET_ALL)
    print(Fore.GREEN, payload, Style.RESET_ALL)
    print()

def showSignatureParts(header, payload):
    print(Fore.LIGHTYELLOW_EX + 'Formato da Assinatura:', Fore.RED + '<header-base64url>.<payload-base64url>', Style.RESET_ALL)
    print(Fore.LIGHTYELLOW_EX + 'O que sera assinado:', Fore.RED + header + Fore.LIGHTYELLOW_EX + '.' + Fore.LIGHTMAGENTA_EX + payload, Style.RESET_ALL)
    print()

def showSignatureFinals(signature):
    print(Fore.LIGHTYELLOW_EX + 'Criptografia para assinatura:' + Fore.LIGHTCYAN_EX + ' HMAC-SHA-256', Style.RESET_ALL)
    print(Fore.LIGHTYELLOW_EX + 'Assinatura:', Fore.LIGHTCYAN_EX + signature, Style.RESET_ALL)
    print()

def showJws(header, payload, signature):
    print(Fore.LIGHTYELLOW_EX + 'Formato JWS:' + Fore.RED + ' <header-base64url>.<payload-base64url>.<assinatura-base64url>', Style.RESET_ALL)
    print(Fore.LIGHTYELLOW_EX + 'JWS:', Fore.RED + header + Fore.WHITE + '.' + Fore.LIGHTMAGENTA_EX + payload + Fore.WHITE + '.' + Fore.LIGHTCYAN_EX + signature, Style.RESET_ALL)
    print()
