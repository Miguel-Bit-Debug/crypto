# RSA - Rivert-Shamir-Adleman

#### Foi o primeiro algoritimo de criptografia de chave publica, é um dos mais seguros algoritimos de criptografia foi o primeiro algoritimo a possibilitar criptografia e assinatura digital

#### Um resumo de como funciona o RSA
    escolha 2 numeros primos P e Q

    Calcule N atraves do produto de P e Q

    Calcule Z onde sera o phi(p) * p(q)
        OBS: Por definição o Phi de um numero primo é ele mesmo menos 1
        Como P e Q são primos o resultado de Z seria
        Z = (p -1) * (q - 1)

    Calcule D, D deve ser um numero primo em relação a Z

    Calcule E, o calculo de E deve respitar a seguinte operação

    (alguma_coisa * d) mod z = 1
    
    esse (alguma_coisa) é um numero que multiplicado por d mod z resulta 1

    ou seja o calculo de E é: (e * d) mod z = 1


#### Temos todo o processo calculado agora podemos encriptar e decriptar a mensagem
    para fazer isso devemos usar os calculos

    TEXTO_ORIGINAL = "teste"
    TEXTO_CRIFRADO = (TEXTO_ORIGINAL ^ E) mod N

    Para descriptografar usamos o seguinte calculo

    TEXT_PLAIN = (TEXTO_CRIFRADO ^ D) mod N

#### Exemplo pratico de utilização do RSA
    Defina P e Q

    P = 17
    Q = 11
    N = P * Q
    Z = (P - 1) * (Q - 1)

    N = 17 * 11 = 187
    Z = 16 * 10 = 160

    Calcule D (D deve ser primo em relação a Z)
    D = 7

    Calcule E
    (E * D) mod z = 1

    E = 1 => (1 * 7) mod 160 = 7
    E = 2 => (2 * 7) mod 160 = 14
    E = 3 => (3 * 7) mod 160 = 21
    E = 23 => (23 * 7) mod 160 = 1
    E = 183 => (183 * 7) mod 160 = 1
    E = 343 => (343 * 7) mod 160 = 1
    E = 503 => (503 * 7) mod 160 = 1

    Vamos escolher o 23
    E = 23