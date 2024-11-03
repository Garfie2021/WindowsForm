using Dapper;
using Maintenance.Common;
using Maintenance.Model;
using System.Data.SQLite;

namespace Maintenance.Sql
{
    public static class Sql政権
    {
        public static List<M政権> SelectAll()
        {
            using (var sqliteConnection = new SQLiteConnection(StaticData.ConnectionString))
            {
                const string query = "SELECT * FROM 政権";

                sqliteConnection.Open();
                return sqliteConnection.Query<M政権>(query).AsList();
            }
        }

        public static M政権? SelectById(M政権 m政権)
        {
            using (var sqliteConnection = new SQLiteConnection(StaticData.ConnectionString))
            {
                const string query = "SELECT * FROM 政権 WHERE Id = @Id";

                sqliteConnection.Open();
                return sqliteConnection.QueryFirst<M政権>(query, m政権);
            }
        }

        public static void Add(M政権 m政権)
        {
            using (var sqliteConnection = new SQLiteConnection(StaticData.ConnectionString))
            {
                const string query = "INSERT INTO 政権 (Start, End, Name) VALUES (@Start, @End, @Name)";

                sqliteConnection.Open();
                sqliteConnection.Execute(query, m政権);
            }
        }

        public static void Update(M政権 m政権)
        {
            using (var sqliteConnection = new SQLiteConnection(StaticData.ConnectionString))
            {
                const string query = "UPDATE 政権 SET Start = @Start, End = @End, Name = @Name WHERE Id = @Id";

                sqliteConnection.Open();
                sqliteConnection.Execute(query, m政権);
            }
        }

        public static void Delete(M政権 m政権)
        {
            using (var sqliteConnection = new SQLiteConnection(StaticData.ConnectionString))
            {
                const string query = "DELETE FROM 政権 WHERE Id = @Id";

                sqliteConnection.Open();
                sqliteConnection.Execute(query, m政権);
            }
        }

    }
}
