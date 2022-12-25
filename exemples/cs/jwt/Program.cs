using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using jwt;
using Microsoft.IdentityModel.Tokens;

//var headerSegment = @"{
//    ""typ"":""JWT"", 
//    ""alg"":""HS256""
//}";
var headerRepresentation = new Dictionary<string, object>
{
    { "alg", "HS256" },
    { "typ", "JWT" },
};
var headerSegment = JsonSerializer.Serialize(headerRepresentation, new JsonSerializerOptions() { WriteIndented = false });
JwsExample.ShowHeader(headerSegment);

var payloadRepresentation = new Dictionary<string, object>
            {
                { "claim1", 10 },
                { "claim2", "claim2-value" },
                { "name", "Bruno Brito" },
                { "given_name", "Bruno" },
                { "social", new Dictionary<string, string>()
                    {
                        { "facebook", "brunohbrito" },
                        { "google", "bhdebrito" }
                    }
                },
                { "logins", new[] {"brunohbrito", "bhdebrito", "bruno_hbrito"} },

            };
var payloadSegment = JsonSerializer.Serialize(payloadRepresentation, new JsonSerializerOptions() { WriteIndented = false });
var payloadToShow = JsonSerializer.Serialize(payloadRepresentation, new JsonSerializerOptions() { WriteIndented = true });
JwsExample.ShowPayload(payloadSegment);

// Convert para UTF-8
var headerBytes = Encoding.UTF8.GetBytes(headerSegment);
var payloadBytes = Encoding.UTF8.GetBytes(payloadSegment);
JwsExample.ShowBytes(headerBytes, payloadBytes);

// Converte para Base64Url
var header = Base64UrlEncoder.Encode(headerBytes);
var payload = Base64UrlEncoder.Encode(payloadBytes);
JwsExample.ShowBase64Parts(header, payload);
// Assinatura
var signatureSegment = $"{header}.{payload}";

JwsExample.ShowSignatureParts(header, payload);

// Assina
byte[] chave = new byte[16];
RandomNumberGenerator.Fill(chave);

// Para testar com uma chave fixa
//byte[] chave = Encoding.UTF8.GetBytes("bruno");
var hmac = new HMACSHA256(chave);
var signatureBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(signatureSegment));

// Transforma assinatura em Base64Url
var signature = Base64UrlEncoder.Encode(signatureBytes);
JwsExample.ShowSignatureFinals(signatureBytes, signature);

// Gera o JWS
JwsExample.ShowJws(signature, header, payload);

JwsExample.ShowJwtIoInfo(chave);