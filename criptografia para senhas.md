# Algoritimos para senhas

#### É ideal analisarmos o algoritimo de criptografia ideal para usarmos nos nossos sistemas. Se tratando de senhas podemos usar os seguintes algoritimos recomendados pela OWASP:
    Argon2
    Bcrypt
    Scrypt
    PBKDF2 com iterações e hash HMAC SHA-256

#### Nem todas as linguagens/tecnologias dão suporte para todos esses listados, por isso temos mais de um.

#### Utilizar somente hash para guardar senhas é um erro pois algoritimos de hash como Familia SHA-2, Blake-3, MD5...são algoritimos rapidos e isso permite que um atacante (cracker) tenhas mais possibilidades para testar aquela hash usando força bruta (brute force).

#### Se usarmos hash para guardar senhas, em questão de segundos conseguimos testar milhões de possibilidades, agora utilizando algoritimos sugeridos pela OWASP esse numero cai para casa de centenas.

