using System;
using System.Data.SqlClient;
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

        public static void InjectMe(string username)
        {
            const string password = "hello";
            using (var con = new SqlConnection($"Data Source=localhost;Initial Catalog=Test;User id=admin;Password={password}"))
            {
                var sqlCmd = new SqlCommand("SELECT * FROM USERS WHERE Username='" + username + "'", con);
                var reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0), reader.GetString(1));
                }
            }
        }
    }
}