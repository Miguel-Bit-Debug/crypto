# JWT - Json Web Tokens

#### JWT é uma estrutura de dados no formato JSON, permite trafegar dados na URL sem quebra de caracteres. Podemos pensar nele como uma classe abstrata onde sua implementação se da nas seguintes "classes":
    JWS - Json Web signature (RFC7515)
    JWE - Json Web Encryption (RFC7516)
    JWK - Json Web Key (RFC7517)
    JWA - Json Web Algorith (RFC7518)

#### Após assinar um JWT estará sendo trafegado um JWS, seu conteudo é composto por claims, claims são coleções de chave/valor e fornecem ao Client informações que está consumindo seus serviços


#### A assinatura de um JWT é composto por 3 partes
    Header - [ guarda informações do JWT, tipo de acesso, tipo de algoritimo usado...] 
    Payload - [ guarda informações do client, claims...isso serve para saber qual tipo de acesso aquele usuario tem em determinado endpoint/api ]
    Chave secreta / Assinatura [ somente quem tem a chave é capaz de validar a assinatura, portanto devemos tomar cuidado para não deixar a chave publica ]