using System.Security.Cryptography;
using System.Text;

var mensagem = "Por favor, transfira $100 para o Miguel";
Console.WriteLine("Mensagem: {0}", mensagem);

byte[] chave = new byte[16];
RandomNumberGenerator.Fill(chave);
var hmac = new HMACSHA256(chave);
var hmacResult = hmac.ComputeHash(Encoding.ASCII.GetBytes(mensagem));

Console.WriteLine("Senha: {0}", BitConverter.ToString(chave).ToLower().Replace("-", string.Empty));
Console.WriteLine("HMAC-SHA-256: {0}", BitConverter.ToString(hmacResult).ToLower().Replace("-", string.Empty));