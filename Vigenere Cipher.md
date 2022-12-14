# *Vigenere Cipher - Cifra de Vegenere*

#### A cifra de Vegenere é um tipo de criptografia semelhante a cifra de Cesar, tem uma camada a mais de complexidade.

- Precisamos imaginar um alfabeto com linhas e colunas.
![Vigenere Cipher](/img/vigenere%20cipher.jpg)


- Devemos definir uma chave de secreta

- Devemos encriptar a mensagem de acordo com a chave secreta

- Exemplo:
    - Mensagem de entrada: Miguel
    - Chave secreta: casa

- Para encriptar a mensagem usando a chave secreta devemos pegar a primeira letra da mensagem que está na coluna, devemos pegar a primeira letra da chave que está na linha e verificar em qual letra chegamos a partir dessas duas, veja na imagem:

![Vigenere Cipher](/img/vigenere%20cipher%202.jpg)

- A primeira letra da mensagem é M
- A primeira letra da chave é c
- O resultado das combinações das letras resulta na letra O
- Faça isso para as proximas letras e terá o resultado: Ozejxt

#### É necessário deslocar a letra da CHAVE (linha) até chegarmos na posição da letra da mensagem (coluna) para obter a letra que encriptada.

#### Assim como a cifra de cesar, não devemos usar a cifra de vigenere como algoritimo de criptografia pois é um tipo de criptografia bem simples de ser revertido a mensagem original