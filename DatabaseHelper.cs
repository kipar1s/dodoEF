using System;
using System.Data.OleDb;
using System.IO;

namespace dodoEF
{
    public class DatabaseHelper
    {
        public static void CreateUsersTable()
        {
            // Получаем путь к директории, где находится исполняемый файл
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Поднимаемся на 3 уровня вверх (из bin/Debug/net8.0-windows в корень проекта)
            string projectRoot = Path.Combine(baseDirectory, "..", "..", "..");
            string dbPath = Path.GetFullPath(Path.Combine(projectRoot, "dodoDb2.accdb"));
            
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
            
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                
                // Проверяем, существует ли таблица Users
                var schema = connection.GetSchema("Tables");
                bool tableExists = false;
                foreach (System.Data.DataRow row in schema.Rows)
                {
                    if (row["TABLE_NAME"].ToString() == "Users")
                    {
                        tableExists = true;
                        break;
                    }
                }
                
                if (!tableExists)
                {
                    // Создаем таблицу Users
                    string createTableSql = @"
                        CREATE TABLE Users (
                            Id COUNTER PRIMARY KEY,
                            Username VARCHAR(100) NOT NULL,
                            PasswordHash VARCHAR(255) NOT NULL,
                            Role VARCHAR(50) NOT NULL,
                            FullName VARCHAR(200) NOT NULL,
                            CreatedAt DATETIME NOT NULL,
                            IsActive BIT NOT NULL
                        )";
                    
                    using (OleDbCommand command = new OleDbCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    
                    Console.WriteLine("Таблица Users успешно создана!");
                }
                else
                {
                    Console.WriteLine("Таблица Users уже существует.");
                }
                
                // Обновляем таблицу миграций
                try
                {
                    string insertMigrationSql = @"
                        INSERT INTO __EFMigrationsHistory (MigrationId, ProductVersion)
                        VALUES ('20260601120655_AddUserAuthentication', '8.0.6')";
                    
                    using (OleDbCommand command = new OleDbCommand(insertMigrationSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    // Миграция уже добавлена или таблица не существует
                }
            }
        }
    }
}
