using System.Security.Cryptography;

namespace SecurityTestingDemo.Demo
{
    public class SecurityRulesDemo1
    {
        public static string Username = "admin";
        public static string Password = "hello123";

        public static void EncryptNotSoSafely(string password)
        {
            
            using (var tripleDes = new TripleDESCryptoServiceProvider())
            {
                // do something with provider
            }
        }
    }
}