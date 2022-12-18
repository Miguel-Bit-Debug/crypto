using System.Security.Cryptography;
using System.Text;

var message = "miguel";
var hash = new StringBuilder();

using (var sha256 = SHA256.Create())
{
    var crypto = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));

    foreach (var bytes in crypto)
        hash.Append(bytes.ToString("x2"));
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Hash: {hash}");