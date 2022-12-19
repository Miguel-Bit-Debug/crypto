using System.Security.Cryptography;
using System.Text;

RandomNumberGenerator random = RandomNumberGenerator.Create();
byte[] data = new byte[256];
random.GetBytes(data);

var sb = new StringBuilder("new byte[] { ");
foreach (var b in data) 
    sb.Append(b + ", ");
sb.Append("}");

Console.WriteLine(sb.ToString());