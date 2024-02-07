using System.Data.SqlClient;
using PloomesClient.Dtos;
using PloomesClient.Models;

namespace PloomesClient.Repository
{
    public class AccountRepository(IConfiguration configuration) : IAccountRepository
    {
        readonly string connectionString = configuration.GetConnectionString("Mssql")!;
        public AccountModel Create(AccountCreateDto input)
        {
          string insertSql = "INSERT INTO account (name, email) OUTPUT INSERTED.id, INSERTED.email, INSERTED.name VALUES (@name, @email)";

          using SqlConnection connection = new(connectionString);
          using SqlCommand command = new(insertSql, connection);

          /** build query */
          SqlCommand insertCommand = new(insertSql, connection);
          insertCommand.Parameters.AddWithValue("@name", input.Name);
          insertCommand.Parameters.AddWithValue("@email", input.Email);

          /** execute query */
          connection.Open();
          SqlDataReader reader = insertCommand.ExecuteReader();
          if (reader.HasRows)
          {
            while (reader.Read())
            {
              return AccountModel.ToModel(reader);
            }
          }
          throw new Exception("ACCOUNT_FAILED_CREATE");
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountModel> FindAll()
        {
            throw new NotImplementedException();
        }

        public AccountModel FindOne(long Id)
        {
            throw new NotImplementedException();
        }

        public AccountModel Update(AccountUpdateDto input)
        {
            throw new NotImplementedException();
        }
    }

}