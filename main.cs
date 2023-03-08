using System;
using static System.Environment;
using Npgsql;
using Newtonsoft.Json;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello World12345");
        M();
    }

    public static void M()
    {
        string DBHost = Environment.GetEnvironmentVariable("DBHost");

        string DBPassword = Environment.GetEnvironmentVariable("DBPassword");

        NpgsqlConnectionStringBuilder sb = new();
        sb.Host = DBHost;
        sb.Port = 26257;
        sb.Username = "hanbin";
        sb.Password = DBPassword;
        sb.Database = "defaultdb";

        string connectionString = sb.ConnectionString;
        Console.WriteLine(connectionString);
        NpgsqlConnection conn = new NpgsqlConnection(connectionString);
        conn.Open();

        var cmd = new NpgsqlCommand("SELECT version()", conn);
        var ver = cmd.ExecuteScalar();
        cmd.Dispose();
        Console.WriteLine("sql version {0}\n", ver);

        conn.Close();
        conn.Dispose();

    }

}