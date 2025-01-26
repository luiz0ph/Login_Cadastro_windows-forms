using System;
using Microsoft.Data.Sqlite;

namespace Login_Cadastro_windows_forms.Models;

public static class DataBaseHelper
{
    private static readonly string _connectionString = "Data Source=users.db";

    public static SqliteConnection GetConnection()
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        return connection;
    }

    // Method to initialize the database
    public static void InitializeDatabase()
    {
        using (var connection = GetConnection())
        {
            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT NOT NULL UNIQUE,
                    Password TEXT NOT NULL
            )";

            using (var command = new SqliteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    // Method to create a new user
    public static bool CreateUser(string name, string email, string password)
    {
        try
        {
            using (var connection = GetConnection())
            {
                string insertQuery = @"
                        INSERT INTO Users (Name, Email, Password)
                        VALUES (@Name, @Email, @Password)";

                using (var command = new SqliteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        catch (SqliteException ex)
        {
            Console.WriteLine($"Error creating user: {ex.Message}");
            return false;
        }
    }

    // Method to verify login
    public static bool VerifyLogin(string email, string password)
    {
        try
        {
            using (var connection = GetConnection())
            {
                string selectQuery = @"
                    SELECT COUNT(1)
                    FROM Users
                    WHERE Email = @Email AND Password = @Password
                ";

                using (var command = new SqliteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
        catch (SqliteException ex)
        {
            Console.WriteLine($"Error verifying user: {ex.Message}");
            return false;
        }
    }
}