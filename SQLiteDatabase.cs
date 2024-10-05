using System.Data.SQLite;

namespace HomeFoodRegistration
{
    public class SQLiteDatabase
    {
        private SQLiteConnection connection;

        public SQLiteDatabase(string databaseName)
        {
            string connectionString = $"Data Source={databaseName};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        public void InitializeDatabase()
        {
            connection.Open();
            CreateTable();
        }

        private void CreateTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS Registrations (" +
                         "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                         "Name TEXT NOT NULL, " +
                         "Username TEXT NOT NULL, " +
                         "Phone TEXT NOT NULL, " +
                         "Email TEXT NOT NULL, " +
                         "Password TEXT NOT NULL)";

            ExecuteNonQuery(sql);
        }

        public void ExecuteNonQuery(string sql)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public SQLiteDataReader ExecuteQuery(string sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            return command.ExecuteReader();
        }

        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
