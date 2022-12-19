#r "nuget: Portable.BouncyCastle, 1.9.0"
using System.Security.Cryptography;
using System.Text;

var mensagem = "desenvolvedorio";
Console.WriteLine("Mensagem: {0}", mensagem);
// dotnet não oferece suporte ao 224.

Console.WriteLine();
Console.WriteLine("============= SHA-3 =============");

var SHA3 = (int bitLenght, string mensagem) =>
{
    var hashAlgorithm = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(bitLenght);
    var input = Encoding.UTF8.GetBytes(mensagem);

    hashAlgorithm.BlockUpdate(input, 0, input.Length);
    var result = new byte[bitLenght / 8];
    hashAlgorithm.DoFinal(result, 0);
    return BitConverter.ToString(result).Replace("-", "").ToLowerInvariant();
};

Console.WriteLine("SHA3-224: {0}", SHA3(224, mensagem));
Console.WriteLine("SHA3-256: {0}", SHA3(256, mensagem));
Console.WriteLine("SHA3-384: {0}", SHA3(384, mensagem));
Console.WriteLine("SHA3-512: {0}", SHA3(512, mensagem));


Console.WriteLine();
Console.WriteLine("============= SHA-2 =============");
Console.WriteLine("SHA-224: .NET nao oferece suporte nativo ao 224.");
using (var sha256Hash = SHA256.Create())
{
    var hash = sha256Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
    Console.WriteLine("SHA-256: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
}

using (var sha384Hash = SHA384.Create())
{
    var hash = sha384Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
    Console.WriteLine("SHA-384: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
}

using (var sha512Hash = SHA512.Create())
{
    var hash = sha512Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
    Console.WriteLine("SHA-512: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
}

Console.WriteLine();
Console.WriteLine("============= SHA-1 =============");

using (var sha1 = SHA1.Create())
{
    var hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
    Console.WriteLine("SHA-1: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
}