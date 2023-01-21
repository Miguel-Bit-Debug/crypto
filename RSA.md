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


