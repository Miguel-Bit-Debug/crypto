using System.Security.AccessControl;
/*using System;
using System.Text;

var message = "Miguel";

var n = 21;
var e = 5;

var phi = 12;
var d = 5;

var messageBytes = Encoding.UTF8.GetBytes(message);

System.Console.WriteLine("Mensagem em bytes");
foreach (var item in messageBytes)
{
    Console.Write(item);
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Menssagem criptografada");

var cipher = Math.Pow(77105103117101108, e) % n;
System.Console.WriteLine(cipher);

System.Console.WriteLine();
System.Console.WriteLine("Mensagem descriptografada");

var msg = Math.Pow(cipher, d) % n;

System.Console.WriteLine(msg);
*/

using System.Text;
using System;
var message = "morte ao miojo";

var messageBytes = Encoding.UTF8.GetBytes(message);

System.Console.WriteLine("Bytes da mensagem");

foreach (var item in messageBytes)
{
    System.Console.Write(item + " ");
}

System.Console.WriteLine();

var p = 17;
var q = 23;
var n = p * q;
var totiente = (p -1) * (q - 1);
var e = 3;
var d = 235;


System.Console.WriteLine();
System.Console.WriteLine("Cipher");
foreach (var item in messageBytes)
{
    var cipher = Math.Pow(item, e) % n;
    System.Console.Write(cipher + " ");
}

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Message decifrada");
var cipher = new List<int> { 37, 304, 45, 24, 16, 315, 79, 304, 315, 37, 265, 304, 30, 304 };

foreach (var x in cipher)
{
    var m = Math.Pow(x, d) % n;
    System.Console.Write(m + " ");
}
