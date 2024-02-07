using System.Data.SqlClient;

namespace PloomesClient.Models
{
    public class AccountModel(long Id, string Name, string Email) 
    {
      public long Id { get; set; } = Id;
      public string Name { get; set; } = Name;
      public string Email { get; set; } = Email;

      public static AccountModel ToModel(SqlDataReader reader) {
        return new AccountModel(
          Convert.ToInt64(reader["id"]),
          reader["name"].ToString()!,
          reader["email"].ToString()! 
        );
      }
    }
}