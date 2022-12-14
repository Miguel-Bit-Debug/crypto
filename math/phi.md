# Função Totiente ou tambem Função (phi)φ de Euler

#### É uma função que calcula a quantidade de numeros inteiros positivos que são primos com N não sendo maior que N

    Exemplo: vamos calcular o (phi) φ(N) sendo N 8

    Numeros         Divisores       Primos em comum
       1               1                   Sim
       2               1, 2                Não
       3               1                   Sim
       4               1, 2, 4             Não
       5               1                   Sim
       6               1, 2                Não
       7               1                   Sim

#### Para calcular o (phi) φ de um numero devemos pegar o numero escolhido e observar a quantidade de numeros coprimos em relação ao numero escolhido
#### No exemplo acima o (phi) φ(8) é 4 pois os numeros coprimos com 8 são { 1, 3, 5, 7 } logo devemos somar a quantidade de coprimos que nesse caso é 4

    Mais exemplos:

    (phi) φ(11)

    vamos ver quais são os coprimos com 11

        Numeros         Divisores Em comum       Primos em comum
           1               1                         Sim
           2               1                         Sim
           3               1                         Sim
           4               1                         Sim
           5               1                         Sim
           6               1                         Sim
           7               1                         Sim
           8               1                         Sim
           9               1                         Sim
           10              1                         Sim

    φ(11) = 10

#### Uma curiosidade que podemos observar é que quando N é um numero primo o (phi) φ(N) sempre sera N - 1
    Exemplo: Vamos usar usar os seguintes numeros primos [ 2, 3, 5, 11, 13, 47, 53, 257 ]

    Temos os seguintes resultados:
    φ(2) = 1
    φ(3) = 2
    φ(5) = 4
    φ(11) = 10
    φ(13) = 12
    φ(47) = 46
    φ(53) = 52
    φ(257) = 256
    