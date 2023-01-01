using System.Security.Cryptography;
using System.Text;
static void WriteByteArray(string name, byte[] byteArray)
{
    Console.Write("{0}: {1} bytes, {2}-bit:", name, byteArray.Length, byteArray.Length << 3);
    Console.WriteLine(" -> {0}", BitConverter.ToString(byteArray));
}

var rsa = RSA.Create(2048);

var mensagem = "desenvolvedorio";

Console.WriteLine("========================== ASSINAR DIGITALMENTE =========================");

var assinatura = rsa.SignData(Encoding.UTF8.GetBytes(mensagem), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
WriteByteArray("Assinatura", assinatura);

Console.WriteLine("========================== VALIDAR ASSINATURA =========================");

var assinaturaEstaCorreta = rsa.VerifyData(Encoding.UTF8.GetBytes(mensagem), assinatura, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
Console.WriteLine($"Assinatura esta correta: {assinaturaEstaCorreta}");

