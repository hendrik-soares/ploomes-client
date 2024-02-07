using System.Data.SqlClient;

namespace PloomesClient.Migrations
{
  public class StartDatabaseMigration {
    public static void Run(string connectionString) {
      string insertSql = "CREATE TABLE account (id INT IDENTITY(1,1) PRIMARY KEY, name VARCHAR(256), email VARCHAR(256))";

      using SqlConnection connection = new(connectionString);
      using SqlCommand command = new(insertSql, connection);

      /** execute query */
      connection.Open();
      SqlDataReader reader = command.ExecuteReader();
    }
  }
}