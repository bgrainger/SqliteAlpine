using System;
using Microsoft.Data.Sqlite;

namespace SqliteAlpine
{
    class Program
    {
        static void Main(string[] args)
        {
            using var connection = new SqliteConnection("Data Source=local.db");
            Console.WriteLine("Opening connection...");
            connection.Open();
            Console.WriteLine("Opened connection.");
            using var command = new SqliteCommand("create table test(data integer);", connection);
            command.ExecuteNonQuery();
            Console.WriteLine("Created table.");
        }
    }
}
