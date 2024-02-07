using PloomesClient.Dtos;
using PloomesClient.Models;

namespace PloomesClient.Repository
{
  public interface IAccountRepository {
    public List<AccountModel> FindAll();
    public AccountModel FindOne(long Id);
    public AccountModel Create(AccountCreateDto input);
    public AccountModel Update(AccountUpdateDto input);
    public void Delete(long id);
  }
  
}