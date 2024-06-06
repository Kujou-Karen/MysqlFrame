using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBManager
    {
        private string connectionString; // 数据库连接字符串

        public DBManager(string serverIp, string username, string password)
        {
            // 构建数据库连接字符串
            connectionString = $"Server={serverIp};Uid={username};Pwd={password};";
        }

        public List<string> GetDatabaseNames()
        {
            List<string> databaseNames = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // 查询数据库名称
                MySqlCommand command = new MySqlCommand("SHOW DATABASES", connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    databaseNames.Add(reader.GetString(0));
                }

                reader.Close();
            }

            return databaseNames;
        }

        public Dictionary<string, List<string>> GetTablesInDatabases(List<string> databaseNames)
        {
            Dictionary<string, List<string>> tablesInDatabases = new Dictionary<string, List<string>>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (string databaseName in databaseNames)
                {
                    List<string> tableNames = new List<string>();

                    // 查询指定数据库中的表名
                    MySqlCommand command = new MySqlCommand($"SHOW TABLES FROM {databaseName}", connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        tableNames.Add(reader.GetString(0));
                    }

                    reader.Close();

                    tablesInDatabases.Add(databaseName, tableNames);
                }
            }

            return tablesInDatabases;
        }

        public DataTable GetColumnsInTable(string database, string table)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SHOW COLUMNS FROM {database}.{table}";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable columns = new DataTable();
                        adapter.Fill(columns);
                        return columns;
                    }
                }
            }
        }


    }
}
