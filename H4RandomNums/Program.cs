using System.Diagnostics;
using System.Security.Cryptography;

namespace H4RandomNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encrypter encrypter = new Encrypter();
            encrypter.Encrypt("Hello");
            encrypter.Decrypt("SPXXÆ");
            Console.ReadKey();
        }
        
    }
}