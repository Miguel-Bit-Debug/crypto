using System.Security.Cryptography;
using System.Text;

var mensagens = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

using (var sha256Hash = SHA256.Create())
{
    foreach (var mensagem in mensagens)
    {
        var hash = sha256Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
        Console.WriteLine("SHA-256: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
    }
}

using (var sha512Hash = SHA512.Create())
{
    foreach (var mensagem in mensagens)
    {
        var hash = sha512Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
        Console.WriteLine("SHA-512: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
    }
}

foreach (var mensagem in mensagens)
{
    var hash = Blake3.Hasher.Hash(Encoding.UTF8.GetBytes(mensagem));
    Console.WriteLine("Blake3: {0}", hash);
}