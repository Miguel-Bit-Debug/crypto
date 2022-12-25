using System.Buffers.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace jwt
{
    static class JwsExample
    {
        
        public static void ShowJwtIoInfo(byte[] chave)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("#######################      Validando no jwt.io      #######################");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Chave: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Convert.ToBase64String(chave));
            Console.ResetColor();
        }

        public static void ShowSignatureFinals(byte[] signatureBytes, string signature)
        {
            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 4: Assinando      #######################");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Assinatura: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HMAC-SHA-256");
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Assinatura: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(PrintByteArray(signatureBytes));

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 5: Transforma assinatura em Base64Url      #######################");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Assinatura: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(signature);
            Console.ResetColor();
        }

        public static void ShowBytes(byte[] headerBytes, byte[] payloadBytes)
        {
            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 1: Convertendo para UTF-8      #######################");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Header: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(PrintByteArray(headerBytes));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Payload: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(PrintByteArray(payloadBytes));
            Console.ResetColor();
        }

        public static void ShowJws(string signature, string header, string payload)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 6: Criando o JWS      #######################");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Formato JWS: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("<header-base64url>.<payload-base64url>.<assinatura-base64url");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("JWS: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(header);
            Console.ResetColor();
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(payload);
            Console.ResetColor();
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(signature);
            Console.ResetColor();
        }

        public static void ShowBase64Parts(string header, string payload)
        {
            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 2: Transforma em Base64Url      #######################");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Header: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(header);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Payload: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(payload);
            Console.ResetColor();
        }

        public static void ShowSignatureParts(string header, string payload)
        {

            Console.WriteLine();
            Console.WriteLine("#######################      PASSO 3: Gera a assinatura      #######################");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Formato da Assinatura: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("<header-base64url>.<payload-base64url>");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O que sera assinado: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(header);
            Console.ResetColor();
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(payload);
            Console.ResetColor();
        }

        public static void ShowPayload(string payloadSegment)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Payload:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(payloadSegment);
            Console.ResetColor();
        }

        public static void ShowHeader(string headerSegment)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Header: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(headerSegment);
            Console.ResetColor();
            Console.WriteLine();
            Console.ResetColor();
        }
        public static string PrintByteArray(byte[] bytes)
        {
            var sb = new StringBuilder("new byte[] { ");
            foreach (var b in bytes)
            {
                sb.Append(b + ", ");
            }
            sb.Append("}");
            return sb.ToString();
        }
    }
}
