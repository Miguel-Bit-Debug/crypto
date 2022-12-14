# Diffie Hellman - Criptografia Assimetrica

#### É muito simples multiplicar dois numeros, mas é praticamente impossivel encontrar os numeros originais que foram usados para aquela multiplicação.
    Exemplo:
    O numero 20 pode ser representado pelos seguintes calculos:
    5 x 4
    2 x 10
    1 x 20
    (-2) x (-10)
    (-1) x (-20)
    (-5) x (-4)

    todos as possibilidades acima resultam em 20, e foram apenas alguns 
    exemplos usados para ilustrar que não é tão simples saber qual calculo 
    foi usado para chegar naquele resultado. O resultado pode ser compartilhado 
    mas os numeros (as chaves) que foram multiplicados para chegar no resultado 
    devem ser secretos.

#### O protocolo Diffie Hellman funcionara com numeros naturais com modulo de numero primo é importante que o modulo seja um numero primo

#### Calculo do diffie hellman
    Vamos imaginar que a Miguel quer se comunicar com a Monica em um meio de 
    comunicação inseguro onde Mateus pode interceptar a mensagem.

    Miguel e Monica devem combinar PUBLICAMENTE em um numero para os dois, 
    se tratando de um numero publico Mateus terá acesso.

    Numero publico: 11

    Agora Miguel e Monica devem escolher um numero aleatorio onde não será publico,
    cada um vai ter seu numero privado que não sera compartilhado na 
    rede e Mateus não vai ter acesso.

    Numero privado Miguel: 18
    Numero privado Monica: 3

    Agora ambos devem multiplicar o numero publico combinado entre ambos com seu numero privado.

    Calculo de Miguel: 11 x 18 = 198
    Calculo de Monica: 11 x 3 = 33

    O resultado de Miguel será enviado PUBLICAMENTE para Monica, Mateus vai ter acesso ao resultado.

    O proximo passo é multiplicar o resultado recebido pelo numero privado

    Calculo de Miguel: 18 x 33 = 594
    Calculo de Monica: 198 x 3 = 594

    Perceba que o resultado de ambos é igual portanto essa será a chave de criptografia.

    Como Mateus não tem acesso aos numeros privados, não vai conseguir chegar ao resultado.

    Miguel                     |     Mateus                 |     Monica
    11  (numero publico)       |     11 (numero publico)    |     11 (numero publico)
    18  (numero privado)       |     (sem numero privado)   |     3 (numero privado)
    198 (resultado do calculo) |     198 - 33 (resultados)  |     33 (resultado do calculo)
    594 (chave secreta)        |     (sem chave secreta)    |     594 (chave secreta)

#### Nesse exemplo acima Mateus até pode pegar os resultados publicos e testar todas as combinações possiveis para chegar naqueles resultados ja que não são numeros tão grandes, mas quando pensamos em sistemas devemos utilizar numeros na casa das dezenas ou até mesmo centenas. Isso torna inviavel o calculo reverso para tentar obter as chaves.


