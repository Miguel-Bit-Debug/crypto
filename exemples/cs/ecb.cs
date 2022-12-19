using System.Security.Cryptography;
using System.Text;

var mensagem = "5.io";
RandomNumberGenerator random = RandomNumberGenerator.Create();
byte[] chave = new byte[16];
random.GetBytes(chave);

Console.WriteLine("============== CRIPTOGRAFANDO ==============");

Aes aes = Aes.Create();
aes.Key = chave;
var ciphertext = aes.EncryptEcb(Encoding.UTF8.GetBytes(mensagem), PaddingMode.PKCS7);

Console.WriteLine("Mensagem: {0}", mensagem);
Console.WriteLine("Senha: {0}", Convert.ToHexString(chave));
Console.WriteLine("Cipher: {0}", Convert.ToHexString(ciphertext));
Console.WriteLine();

Console.WriteLine("============== DESCRIPTOGRAFANDO ==============");

Console.WriteLine(Encoding.UTF8.GetString(aes.DecryptEcb(ciphertext, PaddingMode.PKCS7)));