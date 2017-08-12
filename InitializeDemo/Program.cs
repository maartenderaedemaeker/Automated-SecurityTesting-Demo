using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
namespace InitializeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PetDB"].ConnectionString;
            var sql = File.ReadAllText("Create.sql");
            var conn = new SqlConnection(connectionString);
            var server = new Server(new ServerConnection(conn));
            server.ConnectionContext.ExecuteNonQuery(sql);

            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}
