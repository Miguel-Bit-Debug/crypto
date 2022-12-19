using System.Security.Cryptography;
using System.Text;

var mensagens = new[]
{
    "desenvolvedorio",
    "desenvolvedoriodesenvolvedoriodesenvolvedoriodesenvolvedoriodesenvolvedoriodesenvolvedoriodesenvolvedoriodesenvolvedorio",
    "bruno",
    "teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!teste123@32#(@)!",
    "Uma função hash é uma função que recebe como entrada uma sequência de bits (ou bytes) e produz um resultado de tamanho fixo. E o caminho inverso é impossivel. Por isso dizemos que algoritmos de hash são funções one-way.",
    "mensagem secreta",
    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut elementum orci at diam porta rhoncus. Vivamus vel pharetra ante. Duis volutpat aliquet nulla, gravida ornare nisl venenatis ut. Cras ac ante pharetra, blandit orci at, blandit arcu. Nunc felis mi, mollis sed nisi eget, imperdiet facilisis tortor. Curabitur ultrices ex neque, eu mattis nisl pellentesque et. Etiam blandit pulvinar ultricies. Donec bibendum lorem sit amet lorem convallis venenatis. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nulla a sem vel nisl fringilla eleifend in ut ante. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed at nulla aliquet lorem fermentum maximus. Pellentesque ultrices tristique nibh eget bibendum. In vel egestas mauris, et dapibus ipsum. Fusce molestie lectus purus, ut iaculis lorem condimentum id.",
};

using (var sha256Hash = SHA256.Create())
{
    foreach (var mensagem in mensagens)
    {
        var hash = sha256Hash.ComputeHash(Encoding.ASCII.GetBytes(mensagem));
        Console.WriteLine("Hash: {0}", BitConverter.ToString(hash).ToLower().Replace("-", string.Empty));
    }
}
