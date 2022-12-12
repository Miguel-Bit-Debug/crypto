# One Time Pad

#### O One Time Pad é uma cifra que tem em sua composição uma chave aleatória. Imagine um dado com 26 posições, para encriptar a mensagem jogue o dado uma vez e o número que cair será a quantidade de letras você vai deslocar para fazer a substituição da letra original

- Exemplo:
    - Texto de entrada: BANANA
    - Resultado do dado: 7 - logo a letra B se torna G
    - Resultado do dado: 12 - logo z letra A se torna M
    - Faça isso para as próximas letras

    Temos o resultado: GMANSC

#### Perceba que a chave foi gerada de forma aleatória e sem acesso a chave o atacante não irá conseguir chegar na palavra original, o maximo que poderá fazer é testar palavras com brute force (força bruta) e mesmo assim isso resulta em qualquer palavra que, nesse exemplo tem 6 letras.

#### O One Time não deve ser utilizado no mundo real pois é muito pesado, pense em uma transferência de um arquivo de 2GB sua senha criptografada teria 2GB pois para cada bit teria um numero aleatório para substitui-lo.