# Hash Message Authentication Code (MAC)

#### Garantir a integridade de dados é um dos objetivos do HMAC, assinando a informação com um código de autenticação e se essa informação for alterada logo o código é alterado nos informando que houve uma quebra de integridade na informação


#### Exemplo de como funciona o HMAC:
    Chave secreta: ABC123
    Mensagem: Envie 100 reais para o Miguel
    Código de autenticação da mensagem: 2143uiuhuhu4584fef== (somente um exemplo)
    A mensagem será enviada junto com o código de autenticação, quem receber terá que fazer o mesmo 
    calculo para chegar no mesmo código de autenticação enviado, se esse código for diferente significa 
    que houve quebra de integridade, se for igual significa que a integridade se manteve.
    