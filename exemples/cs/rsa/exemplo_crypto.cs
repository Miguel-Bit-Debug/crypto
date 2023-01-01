using System.Security.Cryptography;
using System.Text;

static void WriteByteArray(string name, byte[] byteArray)
{
    Console.Write("{0}: {1} bytes, {2}-bit:", name, byteArray.Length, byteArray.Length << 3);
    Console.WriteLine(" -> {0}", BitConverter.ToString(byteArray));
}

var rsa = RSA.Create(2048);

System.Console.WriteLine(rsa);

// var mensagem = "teste";

// Console.WriteLine("========================== CRIPTOGRAFAR =========================");

// var cypher = rsa.Encrypt(Encoding.UTF8.GetBytes(mensagem), RSAEncryptionPadding.Pkcs1);
// WriteByteArray("Cypher", cypher);

// Console.WriteLine("========================== DESCRIPTOGRAFAR =========================");

// var clearText = rsa.Decrypt(cypher, RSAEncryptionPadding.Pkcs1);
// Console.WriteLine($"Clear text: {Encoding.UTF8.GetString(clearText)}");

